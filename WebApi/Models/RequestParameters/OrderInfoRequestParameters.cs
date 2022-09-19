using Domain.DTOs;

namespace WebApi.Models
{
    public class OrderInfoRequestParameters : RequestParameters
    {
        public string SearchTerm { get; set; } = string.Empty;
        public DataRange DataRange { get; set; } = new DataRange();
        public string OrderBy { get; set; } = string.Empty;
    }
}
