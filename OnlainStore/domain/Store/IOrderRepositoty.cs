using Store.Model;
using System;
using System.Collections.Generic;

namespace Store_Memory
{
    public interface IOrderRepositoty
    {
        Order Add(Order order);

        void RemuveOrderById(int orderId);

        void EditOrder(int id, string status);

        Order ReturnOrderById(int orderId);

        Order GetByUseID(string userId);

        Order GetByName(string name);

        Order GetByPhone(string phone);

        List<Order> GetAllOrder();
    }
}