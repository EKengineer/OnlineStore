using Store_Memory;
using System;
using System.Collections.Generic;

namespace Store_Memory
{
    public class Cart
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public List<CartItem> items { get; set; }

    }
}
