using Domain.DTOs;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System.Globalization;
using System.Reflection;

namespace DataAccess.Repositories.Extensions
{
    public static class IAggregateExtensions
    {
        public static IAggregateFluent<TEntity> Filter<TEntity>(this IAggregateFluent<TEntity> source, List<Filter> filters)
        {
            if(filters == null || filters.Count == 0)
                return source;

            var props = typeof(TEntity).GetProperties().Where(x => x.PropertyType != typeof(Guid)).ToList();
            var mongoProps = GetMongoProperties(props);

            var filterCondition = new BsonDocument();

            foreach(var filter in filters)
            {
                if (filter.Value == null)
                    continue;

                if (filter.Operation == FilterOperations.Contains)
                    filterCondition.Add(mongoProps[filter.Property], new BsonDocument { { "$regex", filter.Value.ToString() }, { "$options", "i" } });
                else if (filter.Operation == FilterOperations.NestedFilterOperation)
                {
                    var nestedType = typeof(TEntity).GetProperty(filter.Property)?.PropertyType.GetGenericArguments()[0];

                    if (nestedType == null)
                        continue;

                    var nestedProps = nestedType.GetProperties().Where(x => x.PropertyType != typeof(Guid)).ToList();

                    var nestedFilterArray = new BsonArray();
                    foreach(var nestedProp in nestedProps)
                    {
                        var mongoProp = nestedProp.GetCustomAttribute<BsonElementAttribute>()!.ElementName;
                        var nestedFilter = new BsonDocument();

                        if (nestedProp.PropertyType == typeof(string))
                            nestedFilter.Add(mongoProp, new BsonDocument { { "$regex", filter.Value.ToString() }, { "$options", "i" } });
                        else if(nestedProp.PropertyType == typeof(decimal))
                        {
                            var parseResult = double.TryParse(filter.Value.ToString(), NumberStyles.Any, new CultureInfo("en-US"), out double doubleValue);
                            if (parseResult)
                                nestedFilter.Add(mongoProp, doubleValue);
                            else
                                continue;
                        }

                        nestedFilterArray.Add( nestedFilter );
                    }

                    filterCondition.Add(mongoProps[filter.Property], new BsonDocument
                    {
                        { "$elemMatch", new BsonDocument{
                            { "$or", nestedFilterArray }
                        } }
                    });
                }
                else if (filter.Operation == FilterOperations.DateTimeEquals)
                {
                    var dateValue = DateTime.Parse(filter.Value.ToString()).ToString("yyyy-MM-dd");
                    filterCondition.Add("$expr", new BsonDocument
                    {
                        { "$eq", new BsonArray{ dateValue, new BsonDocument
                            {
                                { "$dateToString", new BsonDocument
                                    {
                                        { "date", $"${mongoProps[filter.Property]}" }, { "format", "%Y-%m-%d" }
                                    }
                                }
                            }
                        } }
                    });
                }
                else
                    filterCondition.Add("$expr", new BsonDocument
                    {
                        { "$eq", new BsonArray{ filter.Value.ToString(), new BsonDocument{
                                { "$toString", $"${mongoProps[filter.Property]}" }
                            }
                        } }
                    });
            }

            return source.Match(filterCondition);
        }

        public static IAggregateFluent<TEntity> GlobalFilter<TEntity>(this IAggregateFluent<TEntity> source, string globalFilter)
        {
            if (string.IsNullOrEmpty(globalFilter))
                return source;

            var props = typeof(TEntity).GetProperties().Where(x => x.PropertyType != typeof(Guid)).ToList();
            var mongoProps = GetMongoProperties(props);
            var filterConditionArray = new BsonArray();

            foreach(var prop in props)
            {
                var propType = prop.PropertyType;

                if(propType == typeof(string))
                    filterConditionArray.Add(new BsonDocument { { mongoProps[prop.Name], new BsonDocument { { "$regex", globalFilter.ToString() }, { "$options", "i" } } } });
                else if(propType == typeof(DateTime))
                {
                    var parseResult = DateTime.TryParse(globalFilter, out DateTime dateValue);

                    if (!parseResult)
                        continue;

                    filterConditionArray.Add(new BsonDocument
                    {
                        { "$expr", new BsonDocument
                        {
                            { "$eq", new BsonArray{ dateValue.ToString("yyyy-MM-dd"), new BsonDocument
                                {
                                    { "$dateToString", new BsonDocument
                                        {
                                            { "date", $"${mongoProps[prop.Name]}" }, { "format", "%Y-%m-%d" }
                                        }
                                    }
                                }
                            } }
                        } }
                    });
                }
                else if (propType.IsEnum)
                {
                    var parseResult = int.TryParse(globalFilter, out int enumValue);

                    if (!parseResult)
                        continue;

                    filterConditionArray.Add(new BsonDocument { { mongoProps[prop.Name], enumValue } });
                }
                else if(propType == typeof(decimal))
                {
                    var parseRusult = double.TryParse(globalFilter, out double doubleValue);

                    if (!parseRusult)
                        continue;

                    filterConditionArray.Add(new BsonDocument { { mongoProps[prop.Name], doubleValue } });
                }
                else if(propType.IsGenericType && propType.GetGenericTypeDefinition() == typeof(List<>))
                {
                    var nestedType = typeof(TEntity).GetProperty(prop.Name)?.PropertyType.GetGenericArguments()[0];

                    if (nestedType == null)
                        continue;

                    var nestedProps = nestedType.GetProperties().Where(x => x.PropertyType != typeof(Guid)).ToList();

                    var nestedFilterArray = new BsonArray();
                    foreach (var nestedProp in nestedProps)
                    {
                        var mongoProp = nestedProp.GetCustomAttribute<BsonElementAttribute>()!.ElementName;
                        var nestedFilter = new BsonDocument();

                        if (nestedProp.PropertyType == typeof(string))
                            nestedFilter.Add(mongoProp, new BsonDocument { { "$regex", globalFilter }, { "$options", "i" } });
                        else if (nestedProp.PropertyType == typeof(decimal))
                        {
                            var parseResult = double.TryParse(globalFilter, NumberStyles.Any, new CultureInfo("en-US"), out double doubleValue);
                            if (parseResult)
                                nestedFilter.Add(mongoProp, doubleValue);
                            else
                                continue;
                        }

                        nestedFilterArray.Add(nestedFilter);
                    }

                    filterConditionArray.Add(new BsonDocument
                    {
                        { mongoProps[prop.Name], new BsonDocument
                        {
                            { "$elemMatch", new BsonDocument{
                                { "$or", nestedFilterArray }
                            } }
                        } }
                    });
                }
            }

            var filterCondition = new BsonDocument
            {
                { "$or", filterConditionArray }
            };

            return source.Match(filterCondition);
        }

        public static IAggregateFluent<TEntity> DataRange<TEntity>(this IAggregateFluent<TEntity> source, List<DataRange> dataRanges)
        {
            if(dataRanges == null || dataRanges.Count == 0)
                return source;

            var props = typeof(TEntity).GetProperties().Where(x => x.PropertyType != typeof(Guid)).ToList();
            var mongoProps = GetMongoProperties(props);

            var filterCondition = new BsonDocument();

            foreach (var dataRange in dataRanges)
            {
                if (dataRange.Start == null || dataRange.End == null)
                    continue;

                if (!props.Any(x => x.Name == dataRange.Property))
                    continue;

                if(props.FirstOrDefault(x => x.Name == dataRange.Property).PropertyType == typeof(DateTime))
                {
                    var startResult = DateTime.TryParse(dataRange.Start.ToString(), out DateTime startValue);
                    var endResult = DateTime.TryParse(dataRange.End.ToString(), out DateTime endValue);

                    if (!startResult || !endResult)
                        continue;

                    filterCondition.Add("$and", new BsonArray { new BsonDocument
                    {
                        { mongoProps[dataRange.Property], new BsonDocument { { "$gte", startValue }, { "$lte", endValue } } }
                    } });
                }
                else
                {
                    var startValue = double.Parse(dataRange.Start.ToString());
                    var endValue = double.Parse(dataRange.End.ToString());

                    filterCondition.Add("$and", new BsonArray { new BsonDocument
                    {
                        { mongoProps[dataRange.Property], new BsonDocument { { "$gte", startValue }, { "$lte", endValue } } }
                    } });
                }
            }

            return source.Match(filterCondition);
        }

        public static IAggregateFluent<TEntity> Sort<TEntity>(this IAggregateFluent<TEntity> source, string orderBy)
        {
            if (string.IsNullOrEmpty(orderBy))
                return source;

            var orderParams = orderBy.Trim().Split(',');
            var props = typeof(TEntity).GetProperties().Where(x => x.PropertyType != typeof(Guid)).ToList();
            var mongoProps = GetMongoProperties(props);

            BsonDocument sortCondition = new BsonDocument();

            foreach (var param in orderParams)
            {
                if (string.IsNullOrWhiteSpace(param))
                    continue;

                var sortTerm = param.Split(' ')[0];

                var sortProp = mongoProps[sortTerm];
                var direction = param.EndsWith("asc") ? 1 : -1;

                sortCondition.Add(sortProp, direction);
            }

            return source.Sort(sortCondition);
        }

        private static Dictionary<string, string> GetMongoProperties(List<PropertyInfo> props)
        {
            var mongoProps = new Dictionary<string, string>();

            foreach (var prop in props)
            {
                var mongoProp = prop.GetCustomAttribute<BsonElementAttribute>()!.ElementName;
                mongoProps.Add(prop.Name, mongoProp);
            }

            return mongoProps;
        }
    }
}
