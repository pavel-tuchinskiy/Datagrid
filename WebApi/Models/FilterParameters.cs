using Domain.DTOs;

namespace WebApi.Models
{
    public class FilterParameters
    {
        public List<Filter> Filters { get; set; } = new List<Filter>();
        public List<DataRange> DataRanges { get; set; } = new List<DataRange>();
    }
}
