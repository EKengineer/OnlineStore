using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Store
{
    public class Order
    {
        public int Id { get; }

        private List<OrderItem> items;
        public  IReadOnlyCollection<OrderItem> Items
        {
            get { return items; }
        }

        public int TotalCount
        {
            get { return items.Sum(item => item.Count); }
        }

        public decimal TotalPrice
        {
            get { return items.Sum(item => item.Price * item.Count); }
        }

        public Order(int id, IEnumerable<OrderItem> itams)
        {
            if (itams == null)
                throw new ArgumentNullException(nameof(itams));

            Id = id;

            this.items = new List<OrderItem>(itams);
        }

        public void AddItem(Product product, int count)
        {
            var item = items.SingleOrDefault(x => x.ProductId == product.Id);

            if (item == null)
            {
                items.Add(new OrderItem(product.Id, count, product.Cost));
            }
            else
            {
                items.Remove(item);
                items.Add(new OrderItem(product.Id, item.Count + count, product.Cost));
            }
        }

    }
}
