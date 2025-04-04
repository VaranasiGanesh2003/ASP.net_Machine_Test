using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using ASP.net_Machine_Test.Models;

namespace ASP.net_Machine_Test.Controllers
{
    public class CategoryController : Controller
    {
        StoreDbContext dc = new StoreDbContext();

        public ViewResult DisplayCategories()
        {
            var categories = dc.Categories;
            return View(categories);
        }
        public ViewResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public RedirectToRouteResult AddCategory(Category category)
        {
            dc.Categories.Add(category);
            dc.SaveChanges();
            return RedirectToAction("DisplayCategories");
        }
        public ViewResult EditCategory(int id)
        {
            Category category = dc.Categories.Find(id);
            return View(category);
        }
        public RedirectToRouteResult UpdateCategory(Category category)
        {
            dc.Entry(category).State = EntityState.Modified;
            dc.SaveChanges();
            return RedirectToAction("DisplayCategories");
        }
        public RedirectToRouteResult DeleteCategory(int id)
        {
            Category category = dc.Categories.Find(id);
            dc.Categories.Remove(category);
            dc.SaveChanges();
            return RedirectToAction("DisplayCategories");
        }
    }
}