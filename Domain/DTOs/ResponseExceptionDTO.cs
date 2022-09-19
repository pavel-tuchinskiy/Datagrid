namespace Domain.DTOs
{
    public class ResponseExceptionDTO
    {
        public string Message { get; set; }
        public string Source { get; set; }
        public string ErrorCode { get; set; }

        public ResponseExceptionDTO(string message, string source, string errorCode)
        {
            Message = message;
            Source = source;
            ErrorCode = errorCode;
        }
    }
}
