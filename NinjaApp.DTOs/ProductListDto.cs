namespace NinjaApp.DTOs
{
    public class ProductListDto
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public string Unit { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}
