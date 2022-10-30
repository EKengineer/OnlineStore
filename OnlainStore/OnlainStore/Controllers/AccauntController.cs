using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OlineStore.Models;
using Store_Memory.models;
using Store_Memory;

namespace OlineStore.Controllers
{
    public class AccauntController : Controller
    { 
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public AccauntController( UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [HttpPost]
        public IActionResult SignIn(OlineStore.Models.SignIn signIn)
        {
            if (ModelState.IsValid)
            {
                var result = _signInManager.PasswordSignInAsync(signIn.UserName, signIn.Password, signIn.RememberMe, false).Result;
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Неверный пароль");
                    return RedirectToAction("Index", "123");
                }
            }

            return RedirectToAction("Index", "Home");
        }


        [HttpPost]
        public IActionResult SignUp(SignUp signUp)
        {

            
                if (signUp.UserName == signUp.Password)
                {
                    ModelState.AddModelError("", "Логин и пароль не должны совпадать!");
                }
                if (ModelState.IsValid)
                {
                  User user = new User { Email = signUp.UserName, UserName = signUp.UserName };

                var result = _userManager.CreateAsync(user, signUp.Password).Result;
                    
                        ModelState.AddModelError("", "Пароли не совпадают!");
                    
                }
            

           
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Logout()
        {
            _signInManager.SignOutAsync().Wait();
            return RedirectToAction("Index", "Home");
        }
    }
}
