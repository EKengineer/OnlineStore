using LanguageExt.ClassInstances;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.Areas.Admin.Modals;
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
            if (!ModelState.IsValid)
            {
                return View(addNewProduct);
            }
            var id = 0;
            var product = productRepository.GetLastProduct();
            if (product != null)
            {
                 id = product.Id;
            }
            var productDb = new Product
            {
                Name = addNewProduct.Name,
                Cost = addNewProduct.Cost,
                Description = addNewProduct.Description,
                Link = $"/images/image{id + 1}.jpg",
        };
            productRepository.AddNewProduct(productDb);

            return RedirectToAction("Products", "Product");
        }
        [HttpPost]
        public IActionResult EditProduct(int Editid, EditProduct editProduct)
        {
            if (!ModelState.IsValid)
            {
                return View(editProduct);
            }
            var productDb = new Product
            {
                Name = editProduct.ProductName,
                Cost = editProduct.Cost,
                Description = editProduct.Description,
            };
            productRepository.EditProduct(Editid, productDb);

            return RedirectToAction("Products", "Product");
        }
        public IActionResult RemoveProduct(int id)
        {
            productRepository.RemuveProductById(id);

            return RedirectToAction("Products", "Product");
        }
    }
}
