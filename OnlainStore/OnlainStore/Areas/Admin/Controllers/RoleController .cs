using Microsoft.AspNetCore.Mvc;
using OnlineStore.Areas.Admin.Modals;
using Store_Memory;
using Store_Memory;
using System.Xml.Serialization;

namespace OnlineStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RoleController : Controller
    {

        private readonly IRoleRepositoty roleRepositoty;

        public RoleController(IRoleRepositoty roleRepositoty)
        {

            this.roleRepositoty = roleRepositoty;
        }

        public IActionResult Roles()
        {
            var roles = roleRepositoty.GetAllRole();

            return View(roles);
        }

        [HttpPost]
        public IActionResult AddRoles(string roleName)
        {
            if (roleRepositoty.GetByName(roleName) != null)
            {
                ModelState.AddModelError("", "Такая роль уже существует");
            }
            if (ModelState.IsValid)
            {
                var roles = roleRepositoty.Create(roleName);
                return RedirectToAction("Roles", "Role");
            }

            return RedirectToAction("Roles", "Role");
        }

        public IActionResult RemuveRoles(string roleName)
        {
            roleRepositoty.Remove(roleName);

            return RedirectToAction("Roles", "Role");
        }
    }
}
