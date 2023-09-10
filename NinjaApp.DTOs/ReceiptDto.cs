namespace NinjaApp.DTOs
{
    public class ReceiptDto
    {
        public int Id { get; set; }
        public string Ürünler { get; set; }
        public string Kategori { get; set; }
        public DateTime Tarih { get; set; }       
        public decimal Toplam { get; set; }
        public int ProductId { get; set; }
        public string ToplamTutar { get; set; }
        public int UserId { get; set; }

    }
}
