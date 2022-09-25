using System.ComponentModel.DataAnnotations;

namespace OlineStore.Models
{
    public class SignUp
    {
        [Required(ErrorMessage = "Не указан email")]
        [EmailAddress(ErrorMessage = "Введите валидныц email")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Не указан пароль")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Не указан повторный пароль")]
        public string ConfirmPassword { get; set; }



    }
}
