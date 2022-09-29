using Microsoft.AspNetCore.Mvc;
using OnlineStore.Areas.Admin.Modals;
using Store;
using Store_Memory;
using System.Xml.Serialization;

namespace OnlineStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IProductRepository productRepository;

        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
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

            return RedirectToAction("Products", "Product");
        }
        [HttpPost]
        public IActionResult EditProduct(int Editid, EditProduct editProduct)
        {
            productRepository.RemuveProductById(Editid);

            productRepository.EditProduct(Editid, editProduct.ProductName, editProduct.Cost, editProduct.Description);

            return RedirectToAction("Products", "Product");
        }
        public IActionResult RemoveProduct(int id)
        {
            productRepository.RemuveProductById(id);

            return RedirectToAction("Products", "Product");
        }
    }
}
