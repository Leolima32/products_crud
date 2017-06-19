using System.Collections.Generic;
using System.Linq;
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
            ProductIndex model = new ProductIndex() {
                allProducts = _unit.Product.GetProducts(),
                allCategories = _unit.Category.GetAllCategories()
            };
            foreach(var item in model.allProducts) {
                item.productImagePath = item.productImagePath ?? "\\images\\placeholder.png";
                IEnumerable<CategoryProducts> c = _unit.CategoryProducts.GetCategoriesProductsPerProductId(item.productId);
                item.Categories = new List<Category>();
                foreach (var s in c)
                {
                    Category category = _unit.Category.GetCategoryById(s.categoryId);
                    item.Categories.Add(category);
                }
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Create () {
            ViewBag.Categories = _unit.Category.GetAllCategories();
            return View();
        }
        [HttpPost]  
        public IActionResult Create(Product product, IEnumerable<int> categories) {
            _unit.Product.Add(product);
            foreach (var item in categories)
            {
               _unit.CategoryProducts.Add(new CategoryProducts() { productId = product.productId, categoryId = item });
            }
            _unit.Commit();
            return RedirectToAction("Index");
        }
    }
}