using Domain.DTOs;
using WebApi.Models;

namespace WebApi.Helpers
{
    public static class RequestParametersParser<T> where T : RequestParameters
    {
        public static RequestParametersDTO ParseParameters(T parameters)
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
