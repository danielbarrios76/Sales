﻿using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Products
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }
    }
}
