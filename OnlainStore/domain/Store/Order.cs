using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    public class Order
    {
        public int Id { get; }

        public string Name { get;}

        public string Phone { get;}

        public string Address { get;}

        public Cart Cart { get; }


        public Order (int id, string name, string phone, string address, Cart cart)
        {
            Id = id;
            Name = name;
            Phone = phone;
            Address = address;
            Cart = cart;
        }

        public string GetUserID()
        {
            var userId = Cart.UserId;
            return userId;
        }

    }
}
