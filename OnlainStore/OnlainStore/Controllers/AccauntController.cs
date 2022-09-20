using Microsoft.AspNetCore.Mvc;
using OlineStore.Models;

namespace OlineStore.Controllers
{
    public class AccauntController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignIn(SignIn signIn)
        {
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public IActionResult SignUp(SignUp signUp)
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
