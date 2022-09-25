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
using OlineStore.Models;

namespace OnlainStore.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly IProductRepository productRepository;

        public HomeController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public IActionResult Index()
        {
            var result = productRepository.GetAllProduct();

            return View(result);
        }
        //public IActionResult Index(SignIn signIn) 
        //{
        //    var result = productRepository.GetAllProduct();

        //    return View(signIn);
        //}
        //public IActionResult Index(SignIn signIn)
        //{

        //    return View(signIn);
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
