using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Store
{
    public class Cart
    {
        public int Id { get; }

        public string UserId { get; set; }

        public List<CartItem> items{ get; set; }


 
        

    }
}
