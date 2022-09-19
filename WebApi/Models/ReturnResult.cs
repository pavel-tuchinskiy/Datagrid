using Domain.DTOs;

namespace WebApi.Models
{
    public class ReturnHttpResult
    {
        public int StatusCode { get; set; }
        public dynamic Data { get; set; }
        public ResponseExceptionDTO Exception { get; set; }

        public ReturnHttpResult(int statusCode, dynamic data = null, ResponseExceptionDTO exception = null)
        {
            StatusCode = statusCode;
            Data = data;
            Exception = exception;
        }
    }
}
