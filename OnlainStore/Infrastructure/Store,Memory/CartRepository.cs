using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Store;

namespace Store_Memory
{
    public class CartRepository : ICartRepositoty
    {
        private readonly List<Cart> carts = new List<Cart>();

        public Cart Create(string userID)
        {
            int nexrId = this.carts.Count + 1;
            var cart = new Cart(nexrId, new CartItem[0], userID);

            carts.Add(cart);

            return cart;
        }

        public bool GetCount()
        {
            if (carts.Count == 0)
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
            return carts.FirstOrDefault(cart => cart.UserId == userId);
        }
        public Cart GetById(int id)
        {
            return carts.Single(cart => cart.Id == id);
        }

        public void Update(Cart order)
        {

        }

        public void Clear(string userId)
        {
            var cart = carts.FirstOrDefault(cart => cart.UserId == userId);
            carts.Remove(cart);
        }

    }
}
