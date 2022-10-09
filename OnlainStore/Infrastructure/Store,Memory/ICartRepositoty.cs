using Store_Memory;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store_Memory
{
    public interface ICartRepositoty
    {
        void Clear(string userId);

        void AddItem(Product product, string userId);

        Cart GetByUserId(string userId);

        Cart GetById(int id);

        bool GetCount();

        void ReduceItem(Product product, string userId);

        void RemoveItem(Product product, string userId);
    }
}
