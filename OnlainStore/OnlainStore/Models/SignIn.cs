using System.ComponentModel.DataAnnotations;

namespace OlineStore.Models
{
    public class SignIn
    {
        [Required(ErrorMessage = "Не указан email")]
        [EmailAddress(ErrorMessage = "Введите валидный email")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Не указан пароль")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
