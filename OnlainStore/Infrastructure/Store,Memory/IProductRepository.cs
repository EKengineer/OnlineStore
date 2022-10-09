using System;
using System.Collections.Generic;
using System.Text;

namespace Store_Memory
{
    public interface IProductRepository
    {
        void AddNewProduct(Product product);

        void EditProduct(int id, Product product);

        void RemuveProductById(int productId);

        List<Product> GetAllByProductName(string name);

        List<Product> GetAllProduct();

        Product GetProductById(int id);

        Product GetLastProduct();



    }
}
