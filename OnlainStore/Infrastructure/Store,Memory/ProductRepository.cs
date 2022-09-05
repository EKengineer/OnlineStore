using Store;
using System;

namespace Store_Memory
{
    public class ProductRepository
    {
        private static readonly Product[] products = new[]
        {
            new Product(1, "Iphone 13 Pro Max", 125000, "512 gb"),
            new Product(2, "Sony PS5", 55000, "Home video game console"),
            new Product(3, "Book War and Peace", 1500, "Literary work by the Russian author Leo Tolstoy")
        };

        public static string ReturnAllIdNameCostProduct()
        {
            var result = "";

            for (int i = 0; i < ProductRepository.products.Length; i++)
            {
                result += products[i] + "\n\n";
            }

            return result;
        }

        public static string ReturnIdNameCostDescriptionProduct(int id)
        {
            var result = "";


                result += products[id-1].ToString2();
            

            return result;
        }
    }
}
