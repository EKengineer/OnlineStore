using Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Xml.Linq;

namespace Store_Memory
{
    public class ProductDbRepository : IProductRepository
    {
        private readonly DatabaseContext databaseContext;

        public ProductDbRepository(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        //private  readonly List<Product> products = new List<Product>
        //{
        //    new Product("Iphone 13 Pro Max", 125000, "512 gb"),
        //    new Product("Sony PS5", 55000, "Video game console"),
        //    new Product("War and Peace", 1500, "Literary work by the Russian author Leo Tolstoy")
        //};
        public void AddNewProduct(Product product)
        {
            databaseContext.Products.Add(product);
            databaseContext.SaveChanges();

        }
        public void EditProduct(int id , Product editProduct)
        {
            var product = databaseContext.Products.Single(product => product.Id == id);
            if (editProduct.Name != null)
            { product.Name = editProduct.Name; }
            if (editProduct.Cost != 0)
                product.Cost = editProduct.Cost;
            if (editProduct.Description != null)
                product.Description = editProduct.Description;

            databaseContext.SaveChanges();
        }

        public void RemuveProductById(int productId)
        {
            var product = databaseContext.Products.Single(product => product.Id == productId);
            databaseContext.Products.Remove(product);

            databaseContext.SaveChanges();
        }

        public List<Product> GetAllByProductName(string name)
        {
            return databaseContext.Products.Where(product => product.Name.Contains(name)).ToList();
        }

        public List<Product> GetAllProduct()
        {
            return databaseContext.Products.ToList();
        }
        public Product GetProductById(int id)
        {
            return databaseContext.Products.Single(product => product.Id == id);
        }

        public Product GetLastProduct()
        {
            Product product = null;
            foreach (var prod in databaseContext.Products)
            {
                product = prod;
            }
            return product;
        }
    }
}
