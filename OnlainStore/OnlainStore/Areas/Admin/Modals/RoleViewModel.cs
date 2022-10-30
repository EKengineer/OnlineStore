using System.ComponentModel.DataAnnotations;

namespace OnlineStore.Areas.Admin.Modals
{
    public class RoleViewModel
    {
        [Required]

        public string Name { get; set; }  


    }
}
