using Domain.DTOs;
using WebApi.Models;

namespace WebApi.Helpers
{
    public static class RequestParametersParser<T> where T : RequestParameters
    {
        public static RequestParametersDTO ParseParameters(T parameters)
        {
            if(parameters is OrderInfoRequestParameters)
            {
                var searchParams = new Dictionary<string, string>();
                var orderInfoParameters = parameters as OrderInfoRequestParameters;

                if (!string.IsNullOrEmpty(orderInfoParameters.SearchTerm))
                {
                    searchParams = orderInfoParameters.SearchTerm.Trim().Split(',', StringSplitOptions.TrimEntries)
                        .Select(param => param.Split('='))
                        .ToDictionary(s => s[0], s => s[1].ToLower());
                }

                return new RequestParametersDTO()
                {
                    SearchParams = searchParams,
                    DataRange = orderInfoParameters.DataRange,
                    GlobalSearchTerm = orderInfoParameters.GlobalSearchTerm,
                    OrderBy = orderInfoParameters.OrderBy,
                    PageNumber = orderInfoParameters.PageNumber,
                    PageSize = orderInfoParameters.PageSize
                };
            }
            else
            {
                return new RequestParametersDTO()
                {
                    GlobalSearchTerm = parameters.GlobalSearchTerm,
                    PageNumber = parameters.PageNumber,
                    PageSize = parameters.PageSize
                };
            }
        }
    }
}
