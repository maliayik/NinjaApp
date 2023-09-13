namespace NinjaApp.DTOs
{
    public class ShoppingDto
    {
        public int Id { get; set; }
        public string Ürünler { get; set; }
        public string Kategori { get; set; }
        public int Birim { get; set; }
        public decimal Fiyat { get; set; }
        public int Adet { get; set; }
    }
}
