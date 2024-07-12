using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFood.Data.Models
{
    public class CartItem
    {
        public int CartItemId { get; set; }
        public int CartId { get; set; }
        public int FoodID { get; set; }
        public int Quantity { get; set; }
        public Food Food { get; set; }
    }
}
