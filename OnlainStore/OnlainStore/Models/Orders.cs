using System.ComponentModel.DataAnnotations;

namespace OlineStore.Models
{
    public class Orders
    {
        [Required(ErrorMessage = "Не указан имя")]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "Имя должно содержать от 2 до 25 символов")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Не указан телефон")]
        public string Phone { get; set; }


        [Required(ErrorMessage = "Не указан адрес")]
        public string Address { get; set; }
    }
}
