using Microsoft.AspNetCore.Mvc;
using OlineStore.Models;
using OnlineStore.Areas.Admin.Modals;
using Store_Memory;
using System.Xml.Serialization;

namespace OnlineStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly IUsersRepository usersRepository;

        public UserController(IUsersRepository usersRepository)
        {
            this.usersRepository = usersRepository;
        }
        public IActionResult Users()
        {
            var users = usersRepository.GetAllUsers();

            return View(users);
        }

        public IActionResult MoreUser(string name)
        {
            var user = usersRepository.GetByEmail(name);
            return View(user);
        }
        //public IActionResult ChangePassword(string name)
        //{
        //    var changePassword = new ChangePassword() { Name = name };

        //    return View(changePassword);
        //}

        [HttpPost]
        public IActionResult ChangePassword(int userId, ChangePassword changePassword)
        {
            var user = usersRepository.GetById(userId);


            if (user.Email == changePassword.Password)
            {
                ModelState.AddModelError("", "Логин и пароль не должны совпадать!");
            }
            if (ModelState.IsValid)
            {
                if (changePassword.Password == changePassword.ConfirmPassword)
                {
                    usersRepository.ChangePassword(user.Email, changePassword.Password);
                    return RedirectToAction("Users", "User");
                }
                else
                {
                    ModelState.AddModelError("", "Пароли не совпадают!");
                }
            }
            return RedirectToAction("Users", "User");
        }

         public IActionResult RemoveUser(string email)
        {
            usersRepository.Remove(email);

            return RedirectToAction("Users", "User");
        }

        [HttpPost]
        public IActionResult EditUser(int userId, EditUser editUser)
        {
            var user = usersRepository.GetById(userId);

            if (editUser.Email == null)
            { editUser.Email = user.Email; }
            if (editUser.Phone == null)
            { editUser.Phone = user.Phone; }
            if (editUser.Name == null) 
            { editUser.Name = user.Name; }
            if (editUser.Address == null)
            { editUser.Address = user.Address; }

                usersRepository.EditUser(userId, editUser.Email, editUser.Phone, editUser.Name, editUser.Address);

            return RedirectToAction("Users", "User");
        }
    }
}
