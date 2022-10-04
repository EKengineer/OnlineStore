using Store;
using System.Collections.Generic;
using System;
using System.Linq;

namespace OnlineStore.Models
{
    public class CartViewModel
    {
        public int Id { get; }

        public string UserId { get; set; }

        public List<CartItemViewModel> items { get; set; }


        public int TotalCount
        {
            get { return items?.Sum(item => item.Count) ?? 0; }
        }

        public decimal TotalPrice
        {
            get { return items.Sum(item => item.Product.Cost * item.Count); }
        }

        public CartViewModel(int id, List<CartItemViewModel> itams, string userId)
        {
            if (itams == null)
                throw new ArgumentNullException(nameof(itams));
            Id = id;

            UserId = userId;

            items = new List<CartItemViewModel>(itams);
        }
    }
}
