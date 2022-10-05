using OnlineStore.Models;
using Store;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace OlineStore.Models
{
    public class OrderViewModel
    {
        public int Id { get; }
        [Required(ErrorMessage = "Не указан имя")]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "Имя должно содержать от 2 до 25 символов")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Не указан телефон")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Не указан Email")]
        [EmailAddress(ErrorMessage = "Укажите валидный Email")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Не указан адрес")]
        public string Address { get; set; }

        public string Comment { get; set; }

        public DateTime DateTime { get; }

        public string Status { get; }

        public List<CartItemViewModel> CartItemViewModel { get; set; }


        public int TotalCount()
        {
             return CartItemViewModel?.Sum(item => item.Count) ?? 0; 
        }

        public decimal TotalPrice()
        {
             return CartItemViewModel.Sum(item => item.Product.Cost * item.Count); 
        }

        public OrderViewModel(int id, string name, string phone, string email, string address, string comment, List<CartItemViewModel> cartItemViewModel)
        {
            Id = id;
            Name = name;
            Phone = phone;
            Email = email;
            Address = address;
            Comment = comment;
            CartItemViewModel = cartItemViewModel;
            DateTime = DateTime.Now;
            Status = "Создан";
        }
        public OrderViewModel(int id, string name, string phone, string email, string address, string comment, DateTime dateTime, string status, List<CartItemViewModel> cartItemViewModel)
        {
            Id = id;
            Name = name;
            Phone = phone;
            Email = email;
            Address = address;
            Comment = comment;
            CartItemViewModel = cartItemViewModel;
            DateTime = dateTime;
            Status = status;
        }
        public OrderViewModel()
        {
            DateTime = DateTime.Now;
            Status = "Создан";
        }
    }
}
