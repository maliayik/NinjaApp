using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjaApp.DTOs
{
    public class ShoppingDto
    {
        public int Id { get; set; }
        public string Ürünler { get; set; }
        public string Kategori { get; set; }
        public string Birim { get; set; }
        public decimal Fiyat { get; set; }
        public int  Adet { get; set; }
    }
}
