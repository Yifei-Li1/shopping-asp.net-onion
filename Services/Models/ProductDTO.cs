﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Models
{
    public class ProductDTO
    {
        public int ProductID { get; set; }
        public string Model { get; set; }
        public string Series { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
