using Microsoft.AspNetCore.Mvc;
using products_crud.Models;
using products_crud.Repositories;

namespace products_crud
{
    public class CategoriesController: Controller {
        private readonly IUnitOfWork _unit;
        public CategoriesController (IUnitOfWork unit) {
            _unit = unit;
        }

        public IActionResult Index () {
            return View(_unit.Category.GetAllCategories());
        }

        [HttpPost]
        public IActionResult Create(Category category) {
            _unit.Category.Add(category);
            _unit.Commit();
            return RedirectToAction("Index");
        }
    }
}