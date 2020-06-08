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
            var producto = new Product();

            producto.CreatedBy = "testUser";
            producto.ChangedBy = "testUser";

            producto.Title = form["title"];
            producto.Description = form["description"];
            producto.ArtistId = Convert.ToInt32(form["artistId"]);
            producto.Image = form["image"];
            producto.Price = Convert.ToInt32(form["price"]);

            ProductManagement.AddProduct(producto);

            return RedirectToAction("Index");
        }
    }
}