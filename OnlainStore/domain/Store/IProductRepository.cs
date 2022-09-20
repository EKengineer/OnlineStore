using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    public interface IProductRepository
    {
        void AddNewProduct(string name, decimal cost, string description);

        List<Product> GetAllByProductName(string name);

        List<Product> GetAllProduct();


        Product ReturnIdNameCostDescriptionProduct(int id);


    }
}
