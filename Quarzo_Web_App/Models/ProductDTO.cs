﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quarzo_Web_App.Models
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
    }
}