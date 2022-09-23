namespace Domain.DTOs
{
    public class Filter
    {
        public string Property { get; set; }
        public object Value { get; set; }
        public FilterOperations Operation { get; set; }
        public List<Filter> NestedObjectFilter { get; set; }
    }
}
