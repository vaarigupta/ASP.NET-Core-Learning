using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdersAPI.Model
{
    public class Order
    {
        public string Id { get; set; }
        public float Amount { get; set; }

        public Order(string Id, float Amount)
        {
            this.Id = Id;
            this.Amount = Amount;
        }
        
    }
}
