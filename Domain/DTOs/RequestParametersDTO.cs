﻿namespace Domain.DTOs
{
    public class RequestParametersDTO
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public Dictionary<string, string> SearchParams { get; set; }
        public DataRange DataRange { get; set; }
        public string GlobalSearchTerm { get; set; } = string.Empty;
        public string OrderBy { get; set; } = string.Empty;
    }
}
