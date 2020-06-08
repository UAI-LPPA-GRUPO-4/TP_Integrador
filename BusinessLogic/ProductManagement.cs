using Common.Entities;
using DataAccess.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ProductManagement : IProductManagement
    {
        public IList<Product> GetAllProducts()
        {
            return (IList<Product>)ProductFacade.GetInstance().GetAll();
        }

        public Product Get(int id)
        {
            return ProductFacade.GetInstance().Get(id);
        }

        public void AddProduct(Product prod)
        {
            ProductFacade.GetInstance().Create(prod);
        }


        public void Update(Product prod)
        {
             ProductFacade.GetInstance().Update(prod);
        }

        public void Delete(Product prod)
        {
            ProductFacade.GetInstance().Delete(prod);
        }
    }
}
