using Domain.DTOs;
using Domain.DTOs.OrderInfo;
using Domain.DTOs.Product;
using Domain.Entities;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace DataAccess.Repositories.RepositoryExtensions
{
    static class RepositoryOperationsExtenstions
    {
        private enum OrderInfoProperty
        {
            Id,
            Products,
            TotalPrice,
            OrderDate,
            Status,
            Address,
            FirstName,
            LastName,
            Phone,
            UserId
        }

        private enum ProductsProprty
        {
            Id,
            Name,
            Price
        }

        public enum ExpressionOperation
        {
            AND,
            OR
        }

        public static IQueryable<OrderInfoDTO> Search(this IQueryable<OrderInfoDTO> orderInfo, Dictionary<string, string> searchParams)
        {
            if(searchParams.Count == 0)
            {
                return orderInfo;
            }

            var expression = GetOrderInfoExpression(searchParams, ExpressionOperation.AND);

            if(expression != null)
            {
                return orderInfo.Where(expression);
            }
            else
            {
                return orderInfo;
            }
        }

        public static IQueryable<OrderInfoDTO> GlobalSearch(this IQueryable<OrderInfoDTO> orderInfo, string searchTerm)
        {
            if (string.IsNullOrEmpty(searchTerm))
                return orderInfo;

            var lcSearchTerm = searchTerm.Trim().ToLower();
            var searchParams = typeof(OrderInfoDTO).GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Where(x => x.Name != nameof(OrderInfoProperty.Id) && x.Name != nameof(OrderInfoProperty.UserId))
                .ToDictionary(s => s.Name, s => lcSearchTerm);

            var expression = GetOrderInfoExpression(searchParams, ExpressionOperation.OR);

            if (expression != null)
            {
                return orderInfo.Where(expression);
            }
            else
            {
                return orderInfo;
            }
        }

        private static LambdaExpression GetOrderInfoExpression(Dictionary<string, string> searchParams, ExpressionOperation expressionOperation)
        {
            var parameterExp = Expression.Parameter(typeof(OrderInfoDTO));
            var methods = GetMethods();

            Expression body = null;

            foreach (var param in searchParams)
            {
                var propertyExp = Expression.Property(parameterExp, param.Key);

                MethodCallExpression methodCallExp;

                if (param.Key.Equals(nameof(OrderInfoProperty.OrderDate), StringComparison.CurrentCultureIgnoreCase))
                {
                    if(DateTime.TryParse(param.Value, out DateTime parsedParam))
                    {
                        var parsedValExpr = Expression.Constant(parsedParam.Date, typeof(DateTime));
                        var datePropExpr = Expression.Property(propertyExp, "Date");

                        methodCallExp = Expression.Call(datePropExpr, methods["dateEquals"], parsedValExpr);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if(param.Key.Equals(nameof(OrderInfoProperty.TotalPrice), StringComparison.CurrentCultureIgnoreCase))
                {
                    if(decimal.TryParse(param.Value, out decimal paramParse))
                    {
                        var decimalVal = Expression.Constant(paramParse, typeof(decimal));
                        methodCallExp = Expression.Call(propertyExp, methods["decimalEquals"], decimalVal);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if(param.Key.Equals(nameof(OrderInfoProperty.Status), StringComparison.CurrentCultureIgnoreCase))
                {
                    if(Enum.TryParse(typeof(OrderStatus), param.Value, out var statusObj))
                    {
                        var enumVal = Expression.Constant(statusObj, typeof(object));
                        methodCallExp = Expression.Call(propertyExp, methods["enumEquals"], enumVal);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if(param.Key.Equals(nameof(OrderInfoProperty.Products), StringComparison.CurrentCultureIgnoreCase))
                {
                    var productsLambda = GetProductsLambdaExpression(methods, param.Value);
                    methodCallExp = Expression.Call(methods["anyProducts"], propertyExp, productsLambda);
                }
                else
                {
                    var valueExpr = Expression.Constant(param.Value, typeof(string));
                    methodCallExp = Expression.Call(propertyExp, methods["contains"], valueExpr);
                }

                if (body != null)
                    body = expressionOperation == ExpressionOperation.AND
                            ? Expression.AndAlso(body, methodCallExp)
                            : Expression.OrElse(body, methodCallExp);
                else
                    body = methodCallExp;
            }

            if(body != null)
                return Expression.Lambda(body, parameterExp);
            else
                return null;
        }

        private static LambdaExpression GetProductsLambdaExpression(Dictionary<string, MethodInfo> methods, string seacrhTerm)
        {
            var productParams = typeof(ProductDTO).GetProperties(BindingFlags.Public | BindingFlags.Instance)
                        .Where(x => x.Name != nameof(ProductsProprty.Id))
                        .ToList();

            var productProp = Expression.Parameter(typeof(ProductDTO));
            Expression innerBody = null;

            foreach (var innerParam in productParams)
            {
                var innerPropertyExp = Expression.Property(productProp, innerParam);
                MethodCallExpression innerMethodCallExp;

                if (innerParam.Name == nameof(ProductsProprty.Name))
                {
                    var stringExpr = Expression.Constant(seacrhTerm, typeof(string));
                    innerMethodCallExp = Expression.Call(innerPropertyExp, methods["contains"], stringExpr);
                }
                else
                {
                    if (decimal.TryParse(seacrhTerm, out decimal intParam))
                    {
                        var decimalVal = Expression.Constant(intParam, typeof(decimal));
                        innerMethodCallExp = Expression.Call(innerPropertyExp, methods["decimalEquals"], decimalVal);
                    }
                    else
                        continue;
                }

                if (innerBody == null)
                {
                    innerBody = innerMethodCallExp;
                }
                else
                {
                    innerBody = Expression.OrElse(innerBody, innerMethodCallExp);
                }
            }

            return Expression.Lambda(innerBody, productProp);
        }

        public static IQueryable<OrderInfoDTO> GetDataRange(this IQueryable<OrderInfoDTO> orderInfo, DataRange dataRange)
        {
            Expression<Func<OrderInfoDTO, bool>> dataRangePredicate = x => x.TotalPrice > dataRange.TotalPriceMin && x.TotalPrice < dataRange.TotalPriceMax 
                                                       && x.OrderDate >= dataRange.DateMin && x.OrderDate <= dataRange.DateMax;

            return orderInfo.Where(dataRangePredicate);
        }

        private static Dictionary<string, MethodInfo> GetMethods()
        {
            var contains = typeof(string).GetMethod("Contains", new[] { typeof(string) });
            var any = typeof(Enumerable).GetMethods(BindingFlags.Static | BindingFlags.Public)
                .First(m => m.Name == "Any" && m.GetParameters().Count() == 2);
            var anyForProducts = any.MakeGenericMethod(typeof(ProductDTO));
            var decimalEquals = typeof(decimal).GetMethods(BindingFlags.Public | BindingFlags.Instance)
                .Last(x => x.Name == "Equals");
            var enumEquals = typeof(Enum).GetMethods(BindingFlags.Public | BindingFlags.Instance)
                .Last(x => x.Name == "Equals");
            var dateEqals = typeof(DateTime).GetMethods(BindingFlags.Public | BindingFlags.Instance)
                .Last(x => x.Name == "Equals");

            return new Dictionary<string, MethodInfo>()
            {
                {"contains", contains},
                {"anyProducts", anyForProducts},
                {"decimalEquals", decimalEquals},
                {"enumEquals", enumEquals},
                {"dateEquals", dateEqals}
            };
        }

        public static IQueryable<OrderInfoDTO> Sort(this IQueryable<OrderInfoDTO> orders, string orderBy)
        {
            if (string.IsNullOrWhiteSpace(orderBy))
                return orders.OrderBy(s => s.OrderDate);

            var orderParams = orderBy.Trim().Split(',');
            var propInfo = typeof(OrderInfoDTO).GetProperties(BindingFlags.Public | BindingFlags.Instance);
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

                if (objProp.Name != nameof(OrderInfoProperty.Products))
                    orderQueryBuilder.Append($"{objProp.Name.ToString()} {direction}, ");
                else
                    orderQueryBuilder.Append($"{objProp.Name.ToString()}.{typeof(List<ProductDTO>).GetProperty("Count").Name} {direction}, ");
            }

            var orderQuery = orderQueryBuilder.ToString().TrimEnd(',', ' ');

            if (string.IsNullOrWhiteSpace(orderQuery))
                return orders.OrderBy(s => s.OrderDate);

            return orders.OrderBy(orderQuery);
        }
    }
}
