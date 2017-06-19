using Microsoft.AspNetCore.Mvc;
using products_crud.Models;
using products_crud.Repositories;
using products_crud.ViewModels;

namespace products_crud
{
    public class CategoriesController: Controller {
        private readonly IUnitOfWork _unit;
        public CategoriesController (IUnitOfWork unit) {
            _unit = unit;
        }

        public IActionResult Index () {
            CategoryIndex model = new CategoryIndex(){ allProducts = _unit.Product.GetProducts(), allCategories = _unit.Category.GetAllCategories() };
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(Category category) {
            _unit.Category.Add(category);
            _unit.Commit();
            return RedirectToAction("Index");
        }
    }
}