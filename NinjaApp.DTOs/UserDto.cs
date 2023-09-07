﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjaApp.DTOs
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Username { get; set; }       
        public decimal Balance { get; set; }   
        public int ReceiptId { get; set; }
    }
}
