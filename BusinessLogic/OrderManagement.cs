using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Contracts;
using Common.Entities;
using DataAccess.Implementations;

namespace BusinessLogic
{
    public class OrderManagement : IOrderManagement
    {

        BaseDataService<Order> db;

        BaseDataService<Order> dbOrderDetail;
        public UserManagement UserManagement { get; set; }

        public OrderManagement()
        {
            db = new BaseDataService<Order>();
            UserManagement = new UserManagement();
        }

        public void AddOrder(Order order)
        {
            db.Create(order);
        }

        public Order Get(string name)
        {
            throw new NotImplementedException();
        }

        public Order GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateItem(Order item)
        {
            throw new NotImplementedException();
        }
    }
}
