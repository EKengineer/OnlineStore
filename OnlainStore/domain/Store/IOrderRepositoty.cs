using Store;
using System;
using System.Collections.Generic;

namespace Store_Memory
{
    public interface IOrderRepositoty
    {
        Order Add(string name, string phone, string email, string address, string comment, Cart cart);

        void RemuveOrderById(int orderId);

        void EditOrder(int id, string name, string phone, string email, string address, string comment, string status, DateTime dateTime, Cart cart);

        Order ReturnOrderById(int orderId);

        Order GetByUseID(string userId);

        Order GetByName(string name);

        Order GetByPhone(string phone);

        List<Order> GetAllOrder();
    }
}