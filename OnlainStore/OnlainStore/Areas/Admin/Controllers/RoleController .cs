using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using OnlineStore.Areas.Admin.Modals;
using Store_Memory;
using Store_Memory.models;
using System.Linq;
using System.Xml.Serialization;

namespace OnlineStore.Areas.Admin.Controllers
{
    [Area(Constants.AdminRoleName)]
    [Authorize(Roles = Constants.AdminRoleName)]
    public class RoleController : Controller
    {

        private readonly RoleManager<IdentityRole> roleManager;
        

        public RoleController(RoleManager<IdentityRole> roleManager)
        {

            this.roleManager = roleManager;
        }

        public IActionResult Roles()
        {
            var roles = roleManager.Roles.ToList();

            return View(roles);
        }

        [HttpPost]
        public IActionResult AddRoles(string roleName)
        {
            var result = roleManager.CreateAsync(new IdentityRole(roleName)).Result;

            if (result.Succeeded)
            {
                return RedirectToAction("Roles", "Role");
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return RedirectToAction("Roles", "Role");
        }

        public IActionResult RemuveRoles(string roleName)
        {
            var role = roleManager.FindByNameAsync(roleName).Result;

            if (role != null)
            {
                roleManager.DeleteAsync(role).Wait();
            }
            return RedirectToAction("Roles", "Role");
        }
    }
}
