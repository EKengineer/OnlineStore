using Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Xml.Linq;

namespace Store_Memory
{
    public class ProductRepository : IProductRepository
    {

        private  readonly List<Product> products = new List<Product>
        {
            new Product("Iphone 13 Pro Max", 125000, "512 gb"),
            new Product("Sony PS5", 55000, "Video game console"),
            new Product("War and Peace", 1500, "Literary work by the Russian author Leo Tolstoy")
        };

        public void AddNewProduct(string name,decimal cost,string description)
        {
            Product product = new Product(name, cost, description);

            products.Add(product);


        }
        public void EditProduct(int id ,string name, decimal cost, string description)
        {
            Product product = new Product(id,name, cost, description);

            products.Add(product);


        }
        public void RemuveProductById(int productId)
        {
            var product = products.Single(product => product.Id == productId);
            product.MinusId();
            products.Remove(product);
        }

        public List<Product> GetAllByProductName(string name)
        {
            return products.Where(product => product.Name.Contains(name)).ToList();
        }

        public List<Product> GetAllProduct()
        {
            return products;
        }
        public Product GetProductById(int id)
        {
            return products.Single(product => product.Id == id);
        }
    }
}
