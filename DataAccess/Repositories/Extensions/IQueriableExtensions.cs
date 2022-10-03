using Domain.DTOs;
using System.Linq.Dynamic.Core;
using System.Reflection;
using System.Text;

namespace DataAccess.Repositories.RepositoryExtensions
{
    public static class IQueriableExtensions
    {
        public static IQueryable<TSource> Filter<TSource>(this IQueryable<TSource> source, List<Filter> filters)
        {
            if (filters == null || filters.Count == 0)
                return source;

            foreach(var filter in filters)
            {
                if (filter.Value == null)
                    continue;

                if(filter.Operation == FilterOperations.Contains)
                    source = source.Where($"{filter.Property}.Contains(\"{filter.Value}\")");
                else if(filter.Operation == FilterOperations.DateTimeEquals)
                    source = source.Where($"{filter.Property}.Date == DateTime.Parse(\"{filter.Value}\").Date");
                else if(filter.Operation == FilterOperations.NestedFilterOperation)
                {
                    var nestedType = typeof(TSource).GetProperty(filter.Property)?.PropertyType.GetGenericArguments()[0];

                    if (nestedType == null)
                        continue;

                    var nestedProps = nestedType.GetProperties().Where(x => x.PropertyType != typeof(Guid)).ToList();

                    foreach (var prop in nestedProps)
                    {
                        if(prop.PropertyType == typeof(string))
                            source = source.Where($"{filter.Property}.Any({prop.Name}.Contains(\"{filter.Value}\"))");
                        else if(prop.PropertyType == typeof(decimal))
                        {
                            var parsedResult = decimal.TryParse(filter.Value.ToString(), out decimal result);

                            if(parsedResult)
                                source = source.Where($"{filter.Property}.Any({prop.Name} == {result})");
                        }
                    }
                }
                else
                    source = source.Where($"{filter.Property} == {filter.Value}");
            }

            return source;
        }

        public static IQueryable<TSource> GlobalFilter<TSource>(this IQueryable<TSource> source, string globalSearch)
        {
            if(string.IsNullOrEmpty(globalSearch))
                return source;

            var props = typeof(TSource).GetProperties().Where(x => x.PropertyType != typeof(Guid)).ToList();

            var queryBuilder = new StringBuilder();

            foreach(var prop in props)
            {
                var propType = prop.PropertyType;

                if(propType == typeof(string))
                    queryBuilder.Append($"{prop.Name}.Contains(\"{globalSearch}\") || ");
                else if(propType == typeof(DateTime))
                {
                    var dateResult = DateTime.TryParse(globalSearch, out var dateVal);

                    if(dateResult)
                        queryBuilder.Append($"{prop.Name}.Date == {dateVal}.Date || ");
                }
                else if (propType.IsEnum)
                {
                    var enumResult = int.TryParse(globalSearch, out int enumVal);

                    if(enumResult)
                        queryBuilder.Append($"{prop.Name} == {enumVal} || ");
                }  
                else if(propType.IsGenericType && propType.GetGenericTypeDefinition() == typeof(List<>))
                {
                    var nestedType = propType.GetGenericArguments()[0];
                    var nestedProps = nestedType.GetProperties().Where(x => x.PropertyType != typeof(Guid)).ToList();

                    foreach(var nestedProp in nestedProps)
                    {
                        if (nestedProp.PropertyType == typeof(string))
                            queryBuilder.Append($"{prop.Name}.Any({nestedProp.Name}.Contains(\"{globalSearch}\")) || ");
                        else if(nestedProp.PropertyType == typeof(decimal))
                        {
                            var decimalResult = decimal.TryParse(globalSearch, out decimal decimalVal);

                            if(decimalResult)
                                queryBuilder.Append($"{prop.Name}.Any({nestedProp.Name} == {decimalVal}) || ");
                        }
                    }
                }
                else
                {
                    var decimalParseResult = decimal.TryParse(globalSearch, out decimal decimalVal);
                    if(decimalParseResult)
                        queryBuilder.Append($"{prop.Name} == {decimalVal} || ");
                }
            }

            var query = queryBuilder.ToString().TrimEnd('|', ' ');

            return source.Where(query);
        }

        public static IQueryable<TSource> DataRange<TSource>(this IQueryable<TSource> source, List<DataRange> dataRanges)
        {
            if(dataRanges == null || dataRanges.Count == 0)
                return source;

            var props = typeof(TSource).GetProperties();

            var queryBuilder = new StringBuilder();

            foreach(var dataRange in dataRanges)
            {
                if (dataRange.Start == null || dataRange.End == null)
                    continue;

                if (!props.Any(x => x.Name == dataRange.Property))
                    continue;

                if(props.FirstOrDefault(x => x.Name == dataRange.Property)?.PropertyType == typeof(DateTime))
                    queryBuilder.Append($"({dataRange.Property} >= DateTime.Parse(\"{dataRange.Start}\") & {dataRange.Property} <= DateTime.Parse(\"{dataRange.End}\")) & ");
                else
                    queryBuilder.Append($"({dataRange.Property} >= {dataRange.Start} & {dataRange.Property} <= {dataRange.End}) & ");
            }

            var query = queryBuilder.ToString().TrimEnd('&', ' ');

            if(string.IsNullOrEmpty(query))
                return source;

            return source.Where(query);
        }

        public static IQueryable<TSource> Sort<TSource>(this IQueryable<TSource> source, string orderBy)
        {
            if (string.IsNullOrWhiteSpace(orderBy))
                return source;

            var orderParams = orderBy.Trim().Split(',');
            var propInfo = typeof(TSource).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var orderQueryBuilder = new StringBuilder();

            foreach (var param in orderParams)
            {
                if (string.IsNullOrWhiteSpace(param))
                    continue;

                var propFromQueryName = param.Split(" ")[0];
                var objProp = propInfo.FirstOrDefault(pi => pi.Name.Equals(propFromQueryName, StringComparison.InvariantCultureIgnoreCase));

                if (objProp == null)
                    continue;

                var direction = param.EndsWith(" desc") ? "descending" : "ascending";

                if (objProp.PropertyType.IsGenericType && objProp.PropertyType.GetGenericTypeDefinition() == typeof(List<>))
                    orderQueryBuilder.Append($"{objProp.Name.ToString()}.{objProp.PropertyType.GetProperty("Count").Name} {direction}, ");
                else
                    orderQueryBuilder.Append($"{objProp.Name.ToString()} {direction}, ");
            }

            var orderQuery = orderQueryBuilder.ToString().TrimEnd(',', ' ');

            if (string.IsNullOrWhiteSpace(orderQuery))
                return source;

            return source.OrderBy(orderQuery);
        }
    }
}
