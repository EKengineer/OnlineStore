using OnlineStore.Models;
using Store;
using System;
using System.ComponentModel.DataAnnotations;

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

        public CartViewModel Cart { get; }

        public OrderViewModel(int id, string name, string phone, string email, string address, string comment, CartViewModel cart)
        {
            Id = id;
            Name = name;
            Phone = phone;
            Email = email;
            Address = address;
            Comment = comment;
            Cart = cart;
            DateTime = DateTime.Now;
            Status = "Создан";
        }
    }
}
