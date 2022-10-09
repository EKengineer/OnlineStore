using Store_Memory;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store_Memory
{
    public class CartItem
    {
        public int Id { get; set; }

        public Product Product { get; set; }

        public int Count { get; set; }

        public Cart Cart { get; set; }

    }
}
