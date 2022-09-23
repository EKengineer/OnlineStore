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

        [HttpPost]
        public IActionResult SignIn(SignIn signIn)
        {
            return RedirectToAction("Index", "Home");
        }
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(SignUp signUp)
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
