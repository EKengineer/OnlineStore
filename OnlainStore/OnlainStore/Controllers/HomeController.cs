using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlainStore.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Store;
using Store_Memory;

namespace OnlainStore.Controllers
{
    public class HomeController : Controller
    {

        public Product Index()
        {
            return ProductRepository.ReturnAllProduct();

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
