using Domain.DTOs;

namespace WebApi.Helpers
{
    public class FilterParser<T> where T : class
    {
        public static List<Filter> ParseFilter(T filterObj)
        {
            var props = typeof(T).GetProperties();
            List<Filter> filters = new List<Filter>();

            foreach (var prop in props)
            {
                var propValue = prop.GetValue(filterObj);

                if (propValue == null)
                    continue;

                var valueType = Nullable.GetUnderlyingType(prop.PropertyType);

                if (valueType == null)
                    valueType = prop.PropertyType;

                if (valueType == typeof(string))
                {
                    filters.Add(new Filter
                    {
                        Property = prop.Name,
                        Value = propValue,
                        Operation = FilterOperations.Contains
                    });
                }
                else if (valueType.IsEnum)
                {
                    filters.Add(new Filter
                    {
                        Property = prop.Name,
                        Value = (int)propValue,
                        Operation = FilterOperations.Equals
                    });
                }
                else if (valueType == typeof(DateTime))
                {
                    var dateTime = (DateTime)propValue;

                    filters.Add(new Filter
                    {
                        Property = prop.Name,
                        Value = dateTime.ToString("yyyy-MM-dd"),
                        Operation = FilterOperations.DateTimeEquals
                    });
                }
                else if (valueType.IsClass)
                {
                    var nestedProps = valueType.GetProperties();
                    var nestedFilters = new List<Filter>();

                    foreach (var nestedProp in nestedProps)
                    {
                        var nestedValue = nestedProp.GetValue(propValue);

                        if (nestedValue == null)
                            continue;

                        var nestedType = nestedProp.PropertyType;

                        if (nestedType == typeof(string))
                        {
                            nestedFilters.Add(new Filter
                            {
                                Property = nestedProp.Name,
                                Value = nestedValue,
                                Operation = FilterOperations.Contains
                            });
                        }
                        else
                        {
                            nestedFilters.Add(new Filter
                            {
                                Property = nestedProp.Name,
                                Value = nestedValue,
                                Operation = FilterOperations.Equals
                            });
                        }
                    }

                    filters.Add(new Filter
                    {
                        Property = prop.Name,
                        NestedObjectFilter = nestedFilters,
                        Operation = FilterOperations.NestedFilterOperation
                    });
                }
                else
                {
                    filters.Add(new Filter
                    {
                        Property = prop.Name,
                        Value = propValue,
                        Operation = FilterOperations.Equals
                    });
                }
            }

            return filters;
        }
    }
}
