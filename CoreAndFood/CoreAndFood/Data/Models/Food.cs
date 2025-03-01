﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFood.Data.Models
{
    public class Food
    {
        public int FoodID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
        public double Price { get; set; }
        public string ImageURL { get; set; }
        
        public int stock { get; set; }

        public  int CategoryID { get; set; }
        public  virtual Category Category { get; set; }
    }
}
