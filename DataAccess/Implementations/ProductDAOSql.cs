using Common.Entities;
using DataAccess.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Implementations
{
    internal class ProductDAOSql : IProductDAO
    {
        public void Create(Product p)
        {
            using (DBEntities db = new DBEntities())
            {
                db.Product.Add(p);
                db.SaveChanges();
            }
        }

        public void Update(Product p)
        {
            using (DBEntities db = new DBEntities())
            {
                db.Entry(p).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (DBEntities db = new DBEntities())
            {
                Product product = db.Product.First(p => p.Id == id);
                db.Product.Remove(product);
                db.SaveChanges();
            }
        }

        public Product Get(int id)
        {
            using (DBEntities db = new DBEntities())
            {
                return db.Product.Find(id);
            }
        }

        public IEnumerable<Product> GetAll()
        {
            using (DBEntities db = new DBEntities())
            {
                return db.Product;
            }
        }
    }
}
