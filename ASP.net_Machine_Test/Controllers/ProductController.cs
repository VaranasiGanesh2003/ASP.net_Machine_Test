using ASP.net_Machine_Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using ASP.net_Machine_Test;

namespace ASP.net_Machine_Test.Controllers
{
    public class ProductController : Controller
    {
     StoreDbContext dc=new StoreDbContext();
        public ViewResult displayProducts()
        {
            //dc.Configuration.LazyLoadingEnabled=false;
            var products = dc.Products.Include(p => p.category);
            return View(products);
        }
        public ViewResult displayProduct(int id)
        {
            Product product = dc.Products.Include(p => p.category).Where(p=>p.productId==id).Single();
            return View(product);
        }
        public ViewResult AddProduct()
        {
            ViewBag.categoryId = new SelectList(dc.Categories, "categoryId", "categoryName");
            return View();
        }
        [HttpPost]
        public RedirectResult AddProduct(Product product)
        {
            dc.Products.Add(product);
            dc.SaveChanges();
            return Redirect("displayProducts");
        }
        public ViewResult editProduct(int id)
        {
            Product product = dc.Products.Find(id);
            ViewBag.categoryId = new SelectList(dc.Categories, "categoryId", "categoryName");
            return View(product);
        }
        public RedirectToRouteResult updateProduct(Product product)
        {
            dc.Entry(product).State = EntityState.Modified;
            dc.SaveChanges();
            return RedirectToAction("DisplayProducts");
        }
        public RedirectToRouteResult DeleteProduct(int Id)
        {
            Product product = dc.Products.Find(Id);
            dc.Products.Remove(product);
            dc.SaveChanges();
            return RedirectToAction("DisplayProducts");
        }
    }
}
