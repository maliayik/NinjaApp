﻿namespace NinjaApp.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public int Unit { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }
        public int SuplierId { get; set; }


    }
}
