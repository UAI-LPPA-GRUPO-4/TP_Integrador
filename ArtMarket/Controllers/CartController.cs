using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComprasOnline.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        public ActionResult Index()
        {
            //Get All Cart Items
            return View();
        }

        public ActionResult Add(int id)
        {
            //Add to cart
            return Index();
        }
    }
}