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

        private List<CartItem> items;
        public  IReadOnlyCollection<CartItem> Items
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

        public Cart(int id, IEnumerable<CartItem> itams, string userId)
        {
            if (itams == null)
                throw new ArgumentNullException(nameof(itams));

            Id = id;

            UserId = userId;

            this.items = new List<CartItem>(itams);
        }

        public void AddItem(Product product, int count)
        {
            var item = items.SingleOrDefault(x => x.ProductId == product.Id);

            if (item == null)
            {
                items.Add(new CartItem(product.Id, count, product.Cost, product.Name));
            }
            else
            {
                items.Remove(item);
                items.Add(new CartItem(product.Id, item.Count + count, product.Cost, product.Name));
            }
        }
        public void ReduceItem(Product product, int count)
        {
            var item = items.SingleOrDefault(x => x.ProductId == product.Id);

            if (item != null)
            {
                if (item.Count <= 1)
                {
                    items.Remove(item);
                }
                else
                {
                    items.Remove(item);
                    items.Add(new CartItem(product.Id, item.Count - count, product.Cost, product.Name));
                }
            }
        }

        public void RemoveItem(Product product)
        {
            var item = items.SingleOrDefault(x => x.ProductId == product.Id);

            if (item != null)
            {
                    items.Remove(item);
            }
        }
        

    }
}
