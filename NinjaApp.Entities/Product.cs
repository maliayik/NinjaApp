using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjaApp.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public string Unit { get; set; }
        public decimal Price { get; set; }
        public  int Stock { get; set; }
        public int ShopId { get; set; }
        public int CategoryId { get; set; }
        public int SuplierId { get; set; }      


    }
}
