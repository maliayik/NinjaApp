using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjaApp.Entities
{
    public class Receipt
    {
        public int Id { get; set; }
        public int ProductName { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string ReceiptNo { get; set; }
        public int MyProperty { get; set; }
        public decimal Total { get; set; }
        public int ProductId { get; set; }
        public int ShopId { get; set; }
        public int UserId { get; set; }

    }
}
