using Domain.Models;

namespace Domain.Exceptions
{
    public class ResponseException : Exception
    {
        public string Message { get; set; }
        public string Source { get; set; }
        public ErrorCodes ErrorCode { get; set; }

        public ResponseException(string message, string source, ErrorCodes errorCode = ErrorCodes.Err500)
        {
            Message = message;
            Source = source;
            ErrorCode = errorCode;
        }
    }
}
