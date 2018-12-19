using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventOnContainers.Services.CartApi.Model
{
    public class CartItem
    {

        public string Id { get; set; }
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal OldUnitPrice { get; set; }
        public int Quantity { get; set; }
        public string EventImageUrl { get; set; }

       
    }
}
