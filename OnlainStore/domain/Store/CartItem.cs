using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    public class CartItem
    {
       public int Id { get; }

       public Product Product { get; set; }

       public int Count { get; set; }

       

    }
}
