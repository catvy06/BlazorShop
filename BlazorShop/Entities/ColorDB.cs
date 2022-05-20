﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorShop.Entities
{
    public class ColorDB
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public List<Product> Products { get; set; }

    }
}
