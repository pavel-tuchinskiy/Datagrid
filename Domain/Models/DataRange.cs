namespace Domain.DTOs
{
    public class DataRange
    {
        public string Property { get; set; } = string.Empty;
        public object Start { get; set; }
        public object End { get; set; }
    }
    //public class OrderInfoDataRange
    //{
    //    public DateTime DateMin { get; set; } = new DateTime(2000, 1, 1);
    //    public DateTime DateMax { get; set; } = DateTime.Now;
    //    public int TotalPriceMin { get; set; } = 1;
    //    public int TotalPriceMax { get; set; } = 1000000;
    //}
}
