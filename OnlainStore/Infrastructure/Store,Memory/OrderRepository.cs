using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Store;

namespace Store_Memory
{
    public class OrderRepository : IOrderRepositoty
    {
        private readonly List<Cart> orders = new List<Cart>();

        public void Add(Cart cart)
        {

            this.orders.Add(cart);

        }

    }
}
