using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    public interface IProductRepository
    {
        void AddNewProduct(string name, decimal cost, string description);

        void EditProduct(int id, string name, decimal cost, string description);

        void RemuveProductById(int productId);

        List<Product> GetAllByProductName(string name);

        List<Product> GetAllProduct();


        Product GetProductById(int id);



    }
}
