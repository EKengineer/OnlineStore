using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    public interface ICartRepositoty
    {
        void Clear(string userId);

        Cart Create(string userID);

        Cart GetByUserId(string userId);

        Cart GetById(int id);

        void Update(Cart order);

        bool GetCount();
    }
}
