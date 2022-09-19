using Domain.DTOs;

namespace WebApi.Models
{
    public class OrderRequestParameters : RequestParameters
    {
        public OrderInfoFilter OrderInfoFilter { get; set; } = new OrderInfoFilter();
        public DataRange DataRange { get; set; } = new DataRange();
        public string OrderBy { get; set; } = string.Empty;
    }
}
