using System.ComponentModel.DataAnnotations;

namespace OnlineStore.Areas.Admin.Modals
{
    public class EditProduct
    {
        [Required(ErrorMessage = "Не указано название")]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "Имя должно содержать от 2 до 25 символов")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Не указана цена")]
        public decimal Cost { get; set; }

        [Required(ErrorMessage = "Не указано описание")]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "Имя должно содержать от 2 до 100 символов")]
        public string Description { get; set; }
    }
}
