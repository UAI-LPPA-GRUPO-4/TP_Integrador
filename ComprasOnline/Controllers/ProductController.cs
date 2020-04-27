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
        public ActionResult Create(Product form)
        {
            form.CreatedBy = "testUser";
            form.ChangedBy = "testUser";

            ProductManagement.AddProduct(form);
            return RedirectToAction("Index");
        }
    }
}