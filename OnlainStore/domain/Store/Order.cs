using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    public class Order
    {
        public int Id { get; set; }

        public UserDeliveryInfo User { get; set; }

        public DateTime DateTime { get; set; }

        public string Status { get; set; }

        public string Comment { get; set; }

        public List<CartItem> CartItem { get; set; }

    }
}
