using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    public interface ICartRepositoty
    {
        void Clear(string userId);

        Cart Create(string userID);

        void AddItem(Product product, string userId);

        Cart GetByUserId(string userId);

        Cart GetById(int id);

        bool GetCount();

        void ReduceItem(Product product, string userId);

        void RemoveItem(Product product, string userId);
    }
}
