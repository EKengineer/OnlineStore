using Microsoft.AspNetCore.Mvc;
using OlineStore.Models;
using Store;
using Store_Memory;
using System.Xml.Serialization;

namespace OlineStore.Controllers
{
    public class AdminController : Controller
    {
        private readonly IProductRepository productRepository;
        private readonly IOrderRepositoty orderRepositoty;
        private readonly IRoleRepositoty roleRepositoty;

        public AdminController(IProductRepository productRepository, IOrderRepositoty orderRepositoty, IRoleRepositoty roleRepositoty)
        {
            this.productRepository = productRepository;
            this.orderRepositoty = orderRepositoty;
            this.roleRepositoty = roleRepositoty;
        }
        public IActionResult Orders()
        {
            var order = orderRepositoty.GetAllOrder();

            return View(order);
        }

        public IActionResult Users()
        {
            return View();
        }

        public IActionResult Roles()
        {
            var roles = roleRepositoty.GetAllRole();

            return View(roles);
        }

        [HttpPost]
        public IActionResult AddRoles(string roleName)
        {
            if (roleRepositoty.GetByName(roleName) != null)
            {
                ModelState.AddModelError("", "Такая роль уже существует");
            }
            if(ModelState.IsValid)
            {
                var roles = roleRepositoty.Create(roleName);
                return RedirectToAction("Roles", "Admin");
            }

            return RedirectToAction("Roles", "Admin");
        }

        public IActionResult RemuveRoles(string roleName)
        {
            roleRepositoty.Remove(roleName);

            return RedirectToAction("Roles", "Admin");
        }
        public IActionResult Products()
        {
            var products = productRepository.GetAllProduct();

            return View(products);
        }

        public IActionResult EditOrder(int id, string status)
        {
            var order = orderRepositoty.ReturnOrderById(id);
            orderRepositoty.RemuveOrderById(id);
            orderRepositoty.EditOrder(order.Id, order.Name, order.Phone, order.Email, order.Address, order.Comment, status, order.DateTime, order.Cart);

            return RedirectToAction("Orders", "Admin");
        }

        [HttpPost]
        public IActionResult AddProduct(AddNewProduct addNewProduct)
        {
            productRepository.AddNewProduct(addNewProduct.Name, addNewProduct.Cost, addNewProduct.Description);

             return RedirectToAction("Products", "Admin");
        }
        [HttpPost]
        public IActionResult EditProduct(int id, EditProduct editProduct)
        {
            productRepository.RemuveProductById(id);

            productRepository.EditProduct(id, editProduct.ProductName, editProduct.Cost, editProduct.Description);

            return RedirectToAction("Products", "Admin");
        }
        public IActionResult RemoveProduct(int id)
        {
            productRepository.RemuveProductById(id);

            return RedirectToAction("Products", "Admin");
        }
    }
}
