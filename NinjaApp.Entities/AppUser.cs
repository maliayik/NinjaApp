namespace NinjaApp.Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public decimal Balance { get; set; }
        public int ReceiptId { get; set; }
    }
}
