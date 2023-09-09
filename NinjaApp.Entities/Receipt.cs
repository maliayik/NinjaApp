namespace NinjaApp.Entities
{
    public class Receipt
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string ReceiptNo { get; set; }
        public int SaleCount { get; set; }
        public decimal Total { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }

    }
}
