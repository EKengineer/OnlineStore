using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    public class CartItem
    {
       public int ProductId { get; }

       public string ProductName { get; }  

       public int Count { get; }

       public decimal Price { get; }

        public decimal TotalPrice
        {
            get { return Count * Price; }

        }

        public CartItem(int productid, int count, decimal price, string productName)
        {
            if (count <= 0)
                throw new ArgumentOutOfRangeException("Count must be grater than zero.");

            ProductId = productid;

            ProductName = productName;

            Count = count;

            Price = price;

        }

    }
}
