using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;
using Store;

namespace Store_Memory
{
    public class OrderDbRepository : IOrderRepositoty
    {
        private readonly DatabaseContext databaseContext;

        public OrderDbRepository(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }
        public Order Add(Order order)
        {
            databaseContext.Orders.Add(order);
            databaseContext.SaveChanges();

            return order;
        }
        public void EditOrder(int id, string status)
        {
            var order = databaseContext.Orders.Single(order => order.Id == id);

            order.Status = status;

            databaseContext.SaveChanges();
        }
        public void RemuveOrderById(int orderId)
        {
            var order = databaseContext.Orders.Single(order => order.Id == orderId);
            databaseContext.Orders.Remove(order);

            databaseContext.SaveChanges();
        }
        public Order ReturnOrderById(int orderId)
        {
            var order = databaseContext.Orders.Single(order => order.Id == orderId);

            return order;
        }

        public Order GetByName(string name)
        {

            return databaseContext.Orders.FirstOrDefault(order => order.User.Name == name);
        }

        public Order GetByPhone(string phone)
        {

            return databaseContext.Orders.FirstOrDefault(order => order.User.Phone == phone);
        }

        public List<Order> GetAllOrder()
        {
            return databaseContext.Orders.Include(x => x.CartItem).ThenInclude(x => x.Product).Include(x => x.User).ToList();
        }
    }
}
