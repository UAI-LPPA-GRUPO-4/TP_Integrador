using DataAccess.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Facade
{
    public class ProductFacade : IFacadeCRUD<Product>
    {
        private static ProductFacade instance = new ProductFacade();
        private static ProductDAOSql implementation = new ProductDAOSql(); // todo: esto podría ser un factory

        /// <summary>
        /// Private constructor (singleton).
        /// </summary>
        private ProductFacade() { }

        /// <summary>
        /// Gets the singleton instance.
        /// </summary>
        public static ProductFacade GetInstance()
        {
            return instance;
        }

        public void Create(Product p)
        {
            implementation.Create(p);
        }

        public void Update(Product p)
        {
            implementation.Update(p);
        }

        public void Delete(Product p)
        {
            implementation.Delete(p);
        }

        public Product Get(int id)
        {
            return implementation.Get(id);
        }

        public IEnumerable<Product> GetAll()
        {
            return implementation.GetAll();
        }
    }
}
