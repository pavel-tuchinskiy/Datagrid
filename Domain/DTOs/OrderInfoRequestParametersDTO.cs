namespace Domain.DTOs
{
    public class OrderInfoRequestParametersDTO : RequestParametersDTO
    {
        public List<Filter> Filter { get; set; }
        public OrderInfoDataRange DataRange { get; set; }
        public string OrderBy { get; set; } = string.Empty;
    }
}
