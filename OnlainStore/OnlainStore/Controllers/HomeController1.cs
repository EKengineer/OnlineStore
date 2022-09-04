using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlainStore.Models;
using Store;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
namespace OlineStore.Controllers
{
    public class HomeController4 : Controller
    {
        private readonly IProductRepository productRepository;
        public HomeController4(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public IActionResult Index(string query)
        {
            var product = productRepository.GetAllByName(query);
            return View(product);
        }
    }
}
