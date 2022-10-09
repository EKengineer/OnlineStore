using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Store_Memory;
using Store_Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlineStore.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository productRepository;

        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public IActionResult Index(int id)
        {
            var result = productRepository.GetProductById(id);
            return View(result);

        }
    }
}
