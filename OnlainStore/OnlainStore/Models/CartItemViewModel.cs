using Store;
using System;

namespace OnlineStore.Models
{
    public class CartItemViewModel
    {
        public int Id { get; }

        public Product Product { get; }

        public int Count { get; }

        public decimal TotalPrice
        {
            get { return Count * Product.Cost; }

        }

        public CartItemViewModel(int id, int count, Product product)
        {
            if (count <= 0)
                throw new ArgumentOutOfRangeException("Count must be grater than zero.");

            Id = id;

            Product = product;

            Count = count;


        }
    }
}
