using DataAccess;

namespace WebApi.Models
{
    public class RequestParameters
    {
        public int PageNumber { get; set; } = 1;
        private int pageSize = 10;
        public int PageSize
        {
            get
            {
                return pageSize;
            }
            set
            {
                pageSize = (value > Constants.ORDER_MAX_PAGE_SIZE) ? Constants.ORDER_MAX_PAGE_SIZE : value;
            }
        }
        public string GlobalSearchTerm { get; set; } = string.Empty;
    }
}
