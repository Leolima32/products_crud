using Microsoft.AspNetCore.Mvc;
using products_crud.Models;
using products_crud.Repositories;

namespace products_crud.Controllers
{
    public class ProductController: Controller {
        private readonly IUnitOfWork _unit;
        public ProductController (IUnitOfWork unit) {
            _unit = unit;
        }
        public IActionResult Index () {
            return View(_unit.Product.GetProducts());
        }

        [HttpGet]
        public IActionResult Create () {
            return View();
        }
        [HttpPost]
        public void Create(Product product) {
            _unit.Product.Add(product);
        }
    }
}