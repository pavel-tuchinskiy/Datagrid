namespace Domain.DTOs
{
    public class RequestParametersDTO
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string GlobalSearchTerm { get; set; } = string.Empty;
    }
}
