using Common.Entities;
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
            return Repo.GetAll();
        }

        public void AddProduct(Product prod)
        {
            Repo.Add(prod);
        }
    }

    public static class Repo
    {
        private static IList<Product> data = new List<Product>();

        public static IList<Product> GetAll()
        {
            return data;
        }

        public static void Add(Product prod)
        {
            data.Add(prod);
        }
    }
}
