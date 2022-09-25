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

        public string Email { get; }

        public string Address { get;}

        public DateTime DateTime { get; }

        public string Status { get; }

        public string Comment { get; }

        public Cart Cart { get; }


        public Order (int id, string name, string phone, string email, string address,string comment, Cart cart)
        {
            Id = id;
            Name = name;
            Phone = phone;
            Email = email;
            Address = address;
            Comment = comment;
            Cart = cart;
            DateTime = DateTime.Now;
            Status = "Создан";
        }

        public Order(int id, string name, string phone, string email, string address, string comment, string status, DateTime dateTime, Cart cart)
        {
            Id = id;
            Name = name;
            Phone = phone;
            Email = email;
            Address = address;
            Comment = comment;
            Cart = cart;
            DateTime = dateTime;
            Status = status;
        }

        public string GetUserID()
        {
            var userId = Cart.UserId;
            return userId;
        }

    }
}
