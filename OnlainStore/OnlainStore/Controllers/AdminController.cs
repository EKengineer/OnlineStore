using Microsoft.AspNetCore.Mvc;
using OlineStore.Models;
using Store;

namespace OlineStore.Controllers
{
    public class AdminController : Controller
    {
        private readonly IProductRepository productRepository;

        public AdminController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public IActionResult Orders()
        {
            return View();
        }

        public IActionResult Users()
        {
            return View();
        }

        public IActionResult Roles()
        {
            return View();
        }
        public IActionResult Products()
        {
            var products = productRepository.GetAllProduct();

            return View(products);
        }

        [HttpPost]
        public IActionResult AddProduct(AddNewProduct addNewProduct)
        {
            productRepository.AddNewProduct(addNewProduct.Name, addNewProduct.Cost, addNewProduct.Description);

             return RedirectToAction("Products", "Admin");
        }
    }
}
