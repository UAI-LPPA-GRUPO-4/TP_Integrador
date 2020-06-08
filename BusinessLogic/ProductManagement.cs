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
        ProductFacade facade = new ProductFacade();
        
        public IList<Product> GetAllProducts()
        {
            return (IList<Product>)facade.GetAll();
        }

        public Product Get(int id)
        {
            return facade.Get(id);
        }

        public void AddProduct(Product prod)
        {
            facade.Create(prod);
        }


        public void Update(Product prod)
        {
             facade.Update(prod);
        }

        public void Delete(Product prod)
        {
            facade.Delete(prod);
        }
    }
}
