using Common.Entities;
using System.Collections.Generic;

namespace BusinessLogic
{
    public interface IProductManagement
    {
        IList<Product> GetAllProducts();
        bool AddProduct(Product prod);
    }
}