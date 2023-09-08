﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjaApp.DTOs
{
    public class ReceiptDto
    {
        public int Id { get; set; }
        public string Ürünler { get; set; }
        public DateTime Tarih { get; set; }
        public string FisNo { get; set; }
        public decimal Total { get; set; }
        public string ToplamTutar { get; set; }
        public int UserId { get; set; }

    }
}