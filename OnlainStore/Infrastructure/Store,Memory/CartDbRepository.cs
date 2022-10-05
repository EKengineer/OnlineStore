using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
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

        public void AddItem(Product product, string userId)
        {
            var existingCart = GetByUserId(userId);
            if (existingCart != null)
            {
                var item = existingCart?.items?.FirstOrDefault(x => x.Product.Id == product.Id);
               
                if (item == null)
                {
                    existingCart.items.Add(new CartItem
                    {
                        Product = product,
                        Count = 1,
                        Cart = existingCart,
                    });
                }
                else
                {
                    item.Count++;
                }
            }
            else
            {
                var newCart = new Cart
                {
                    UserId = userId,
                };

                newCart.items = new List<CartItem>
                {
                    new CartItem
                    {
                        Count = 1,
                        Product = product,
                        Cart = newCart,
                    }
                };
                databaseContext.Carts.Add(newCart);

            }

            databaseContext.SaveChanges();
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

            databaseContext.SaveChanges();
        }

        public void RemoveItem(Product product, string userId)
        {
            var existingCart = GetByUserId(userId);
            var item = existingCart.items.SingleOrDefault(x => x.Product.Id == product.Id);

            if (item != null)
            {
                existingCart.items.Remove(item);
            }

            databaseContext.SaveChanges();
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
            return databaseContext.Carts.Include(x => x.items).ThenInclude(x => x.Product).SingleOrDefault(cart => cart.UserId == userId);
        }
        public Cart GetById(int id)
        {
            return databaseContext.Carts.Single(cart => cart.Id == id);
        }

        public void Clear(string userId)
        {
            var cart = GetByUserId(userId);
            databaseContext.Carts.Remove(cart);

            databaseContext.SaveChanges();
        }





    }
}
