using BusinessLogic;
using Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComprasOnline.Controllers
{
    public class ProductController : Controller
    {
        public IProductManagement ProductManagement { get; set; }
        public ProductController()
        {
            ProductManagement = new ProductManagement();
        }
        // GET: Product
        public ActionResult Index()
        {
            return View(ProductManagement.GetAllProducts());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection form)
        {
            var product = new Product();

            product.CreatedBy = "testUser";
            product.ChangedBy = "testUser";

            product.Title = form["title"];
            product.Description = form["description"];
            product.ArtistId = Convert.ToInt32(form["artistId"]);
            product.Image = form["image"];
            product.Price = Convert.ToInt32(form["price"]);

            bool result = ProductManagement.AddProduct(product);
            return RedirectToAction("Index");
        }
    }
}