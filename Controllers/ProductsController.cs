using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using products_crud.Models;
using products_crud.Repositories;
using products_crud.ViewModels;

namespace products_crud.Controllers
{
    public class ProductsController: Controller {
        private readonly IUnitOfWork _unit;
        public ProductsController (IUnitOfWork unit) {
            _unit = unit;
        }
        public IActionResult Index () {
            ProductList model = new ProductList() {
                productList = _unit.Product.GetProducts(),
                disponibleCategories = _unit.Category.GetAllCategories()
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult Create () {
            return View();
        }
        [HttpPost]
        public void Create(Product product) {
            _unit.Product.Add(product);
            _unit.Commit();
        }
    }
}