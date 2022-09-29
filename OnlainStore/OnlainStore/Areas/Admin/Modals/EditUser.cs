using System.ComponentModel.DataAnnotations;

namespace OnlineStore.Areas.Admin.Modals
{
    public class EditUser
    {
        public string Email { get; set; }

        public string Phone { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }
    }
}
