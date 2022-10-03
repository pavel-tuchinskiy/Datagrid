namespace Domain.DTOs
{
    public class OrderInfoRequestParametersDTO : RequestParametersDTO
    {
        public List<Filter> Filters { get; set; }
        public List<DataRange> DataRanges { get; set; }
        public string OrderBy { get; set; } = string.Empty;
    }
}
