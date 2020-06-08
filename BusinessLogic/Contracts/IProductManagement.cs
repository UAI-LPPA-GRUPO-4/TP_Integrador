using Common.Entities;
using System.Collections.Generic;

namespace BusinessLogic
{
    public interface IProductManagement
    {
        IList<Product> GetAllProducts();
        Product Get(int id);
        void AddProduct(Product prod);
        void Update(Product prod);
        void Delete(Product prod);
    }
}