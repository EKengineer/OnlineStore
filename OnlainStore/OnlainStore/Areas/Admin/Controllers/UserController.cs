using Couchbase.Management.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OlineStore.Models;
using OnlineStore.Areas.Admin.Modals;
using OnlineStore.Helpers;
using Store_Memory;
using Store_Memory.models;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace OnlineStore.Areas.Admin.Controllers
{
    [Area(Constants.AdminRoleName)]
    [Authorize(Roles = Constants.AdminRoleName)]
    public class UserController : Controller
    {
        private readonly UserManager<Store_Memory.models.User> userManager;

        public UserController(UserManager<Store_Memory.models.User> userManager)
        {
            this.userManager = userManager;
        }
        public IActionResult Users()
        {
            var users = userManager.Users.ToList();
            return View(users);
        }

        public IActionResult MoreUser(string name)
        {
            var user = userManager.FindByNameAsync(name).Result;
           
            return View(user);
        }
      

        [HttpPost]
        public IActionResult ChangePassword(string name, ChangePassword changePassword)
        {
            var user = userManager.FindByNameAsync(name).Result;


            if (user.UserName == changePassword.Password)
            {
                ModelState.AddModelError("", "Логин и пароль не должны совпадать!");
            }
            if (ModelState.IsValid)
            {
                var newHashPassword = userManager.PasswordHasher.HashPassword(user, changePassword.Password);
                user.PasswordHash = newHashPassword;
                userManager.UpdateAsync(user).Wait();
                return RedirectToAction("Users", "User");
            } 
            return RedirectToAction("Users", "User");
        }

         public IActionResult RemoveUser(string name)
        {
            var user = userManager.FindByNameAsync(name).Result;
            userManager.DeleteAsync(user).Wait();
            return RedirectToAction("Users", "User");
        }

        //[HttpPost]
        //public IActionResult EditUser(string name, EditUser editUser)
        //{
        //    var user = userManager.FindByNameAsync(name).Result;

        //    if (editUser.Email == null)
        //    {
        //        var changeEmailTokenAsync = userManager.GenerateChangeEmailTokenAsync(user, editUser.Email);
        //        userManager.ChangeEmailAsync(user, editUser.Email, changeEmailTokenAsync.Result); 
        //    }
        //    if (editUser.Phone == null)
        //    {
        //        userManager.ChangePhoneNumberAsync();
        //    }
        //    if (editUser.Name == null) 
        //    { editUser.Name = user.UserName; }
        //    if (editUser.Address == null)
        //    { editUser.Address = user.Address; }
            
               
        //    return RedirectToAction("Users", "User");
        //}
    }
}
