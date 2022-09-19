using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    public interface IProductRepository
    {
        Product[] GetAllbiIds(IEnumerable<int> productIds);


        Product[] GetAllProduct();

        string ReturnAllIdNameCostProduct();


        Product ReturnIdNameCostDescriptionProduct(int id);


    }
}
