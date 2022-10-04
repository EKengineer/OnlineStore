using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Model
{
    public class Order
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public DateTime DateTime { get; set; }

        public string Status { get; set; }

        public string Comment { get; set; }

        public Cart Cart { get; set; }

    }
}
