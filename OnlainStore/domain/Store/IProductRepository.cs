using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    public interface IProductRepository
    {
        Product[] GetAllByName(string name);
    }
}
