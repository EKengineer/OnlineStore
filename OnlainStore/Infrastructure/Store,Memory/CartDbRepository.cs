using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using Store;

namespace Store_Memory
{
    public class CartDbRepository : ICartRepositoty
    {
        private readonly DatabaseContext databaseContext;

        public CartDbRepository(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        public Cart Create(string userID)
        {
            int nexrId = databaseContext.Carts.Count() + 1;
            var cart = new Cart
            {
                items = new List<CartItem>(),
                UserId = userID,
            };

            databaseContext.Carts.Add(cart);

            return cart;
        }

        public bool GetCount()
        {
            if (databaseContext.Carts.Count() == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
             
        }
        public Cart GetByUserId(string userId)
        {
            return databaseContext.Carts.FirstOrDefault(cart => cart.UserId == userId);
        }
        public Cart GetById(int id)
        {
            return databaseContext.Carts.Single(cart => cart.Id == id);
        }

        public void Clear(string userId)
        {
            var cart = databaseContext.Carts.FirstOrDefault(cart => cart.UserId == userId);
            databaseContext.Carts.Remove(cart);
        }

        public void AddItem(Product product, string userId)
        {
            var existingCart = GetByUserId(userId);
            if (existingCart != null)
            {
                var item = existingCart.items.SingleOrDefault(x => x.Product.Id == product.Id);
                if (item == null)
                {
                    existingCart.items.Add(new CartItem
                    {
                        Product = product,
                        Count = 1
                    });
                }
                else
                {
                    existingCart.items.Remove(item);
                    existingCart.items.Add(new CartItem
                    {
                        Count = item.Count + 1,
                        Product = product,
                    });
                }
            }
        }

        public void ReduceItem(Product product, string userId)
        {
            var existingCart = GetByUserId(userId);
            var item = existingCart.items.SingleOrDefault(x => x.Product.Id == product.Id);

            if (item != null)
            {
                if (item.Count <= 1)
                {
                    existingCart.items.Remove(item);
                }
                else
                {
                    existingCart.items.Remove(item);
                    existingCart.items.Add(new CartItem
                    {
                        Count = item.Count - 1,
                        Product = product,
                    });
                }
            }
        }

        public void RemoveItem(Product product, string userId)
        {
            var existingCart = GetByUserId(userId);
            var item = existingCart.items.SingleOrDefault(x => x.Product.Id == product.Id);

            if (item != null)
            {
                existingCart.items.Remove(item);
            }
        }


    }
}
