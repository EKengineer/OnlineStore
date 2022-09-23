using Microsoft.AspNetCore.Mvc;
using OlineStore.Models;

namespace OlineStore.Controllers
{
    public class AccauntController : Controller
    {
        public IActionResult SignIn()
        {
            return View();
        }

        public IActionResult Registr()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignIn(SignIn signIn)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Index", "Home");
        }


        [HttpPost]
        public IActionResult SignUp(SignUp signUp)
        {
            if (signUp.UserName == signUp.Password)
            {
                ModelState.AddModelError("","Логин и пароль не должны совпадать!");
            }
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
