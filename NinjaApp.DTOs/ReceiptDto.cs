namespace NinjaApp.DTOs
{
    public class ReceiptDto
    {
        public int Id { get; set; }
        public string Ürünler { get; set; }
        public DateTime Tarih { get; set; }
        public decimal Toplam { get; set; }
        public int Birim { get; set; }
        public string ToplamTutar { get; set; }
        public int UserId { get; set; }

    }
}
