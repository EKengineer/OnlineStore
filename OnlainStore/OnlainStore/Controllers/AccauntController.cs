using Microsoft.AspNetCore.Mvc;
using OlineStore.Models;
using Store_Memory;
using System;

namespace OlineStore.Controllers
{
    public class AccauntController : Controller
    {
        private readonly IUsersRepository usersRepository;

        public AccauntController(IUsersRepository usersRepository)
        {
            this.usersRepository = usersRepository;
        }

        [HttpPost]
        public IActionResult SignIn(OlineStore.Models.SignIn signIn)
        {
            var user = usersRepository.GetByEmail(signIn.UserName);
            if (user != null)
            {
                if (ModelState.IsValid)
                {
                    return RedirectToAction("Index", "Home");
                }
            }

            return RedirectToAction("Index", "Home");
        }


        [HttpPost]
        public IActionResult SignUp(SignUp signUp)
        {

            var user = usersRepository.GetByEmail(signUp.UserName);

            if (user == null)
            {
                if (signUp.UserName == signUp.Password)
                {
                    ModelState.AddModelError("", "Логин и пароль не должны совпадать!");
                }
                if (ModelState.IsValid)
                {
                    if (signUp.Password == signUp.ConfirmPassword)
                    {
                        usersRepository.Create(signUp.UserName, signUp.Password);
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Пароли не совпадают!");
                    }
                }
            }

           
            return RedirectToAction("Index", "Home");
        }
    }
}
