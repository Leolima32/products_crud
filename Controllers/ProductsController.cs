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
            ViewBag.Categories = _unit.Category.GetAllCategories();
            var model = _unit.Product.GetProducts();
            foreach(var item in model) {
                item.productImagePath = item.productImagePath ?? "\\images\\placeholder.png";
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Create () {
            return View();
        }
        [HttpPost]  
        public IActionResult Create(Product product) {
            _unit.Product.Add(product);
            _unit.Commit();
            return RedirectToAction("Index");
        }
    }
}