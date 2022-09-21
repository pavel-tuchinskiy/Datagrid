using Domain.DTOs;

namespace WebApi.Models
{
    public class OrderRequestParameters : RequestParameters
    {
        public OrderInfoFilter OrderInfoFilter { get; set; } = new OrderInfoFilter();
        public OrderInfoDataRange DataRange { get; set; } = new OrderInfoDataRange();
        public string OrderBy { get; set; } = string.Empty;
    }
}
