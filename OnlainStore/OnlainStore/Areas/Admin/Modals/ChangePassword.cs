using System.ComponentModel.DataAnnotations;

namespace OnlineStore.Areas.Admin.Modals
{
    public class ChangePassword
    {

        [Required(ErrorMessage = "Не указан пароль")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Не указан повторный пароль")]
        public string ConfirmPassword { get; set; }



    }
}
