using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Common.Entities;
using BusinessLogic;

namespace ArtMarket.Controllers
{
    public class OrderController : BaseController
    {
        public CartManagement Management { get; set; }
        public OrderManagement OrderManagement { get; set; }

        public OrderController()
        {
            Management = new CartManagement();
            OrderManagement = new OrderManagement();
        }

        // GET: Order
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Checkout()
        {
            var user = TryGetUserId();
            var cart = Management.Get(user);

            Order order = new Order();
            CheckAuditPattern(order, true);
            

            order.OrderDate = DateTime.Now;
            order.ItemCount = cart.CartItems.Count();
            order.TotalPrice = Convert.ToDouble(cart.CartItems.Sum(item => item.Price));
            order.UserId = 1;

            //CheckAuditPattern(order.OrderItems, true);

            order.OrderItems = cart.CartItems.Select(x => new OrderDetail(){ 
            ProductId = x.ProductId,
            Price = x.Price,
            Quantity = x.Quantity,
            CreatedOn = DateTime.Now,
            ChangedOn = DateTime.Now
            }).ToList();

            try{

                OrderManagement.AddOrder(order);

            }
            catch (Exception e)
            {
                ExceptionContext ex = new ExceptionContext();
                ex.Exception = e.InnerException;
                OnException(ex);
            }

            return View(order);
        }
    }
}