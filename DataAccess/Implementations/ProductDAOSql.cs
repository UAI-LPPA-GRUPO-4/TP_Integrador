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
            using (lppaDbContext db = new lppaDbContext())
            {
                db.Product.Add(p);
                db.SaveChanges();
            }
        }

        public void Update(Product p)
        {
            using (lppaDbContext db = new lppaDbContext())
            {
                db.Entry(p).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void Delete(Product p)
        {
            using (lppaDbContext db = new lppaDbContext())
            {
                db.Product.Remove(p);
                db.SaveChanges();
            }
        }

        public Product Get(int id)
        {
            using (lppaDbContext db = new lppaDbContext())
            {
                return db.Product.Find(id);
            }
        }

        public IEnumerable<Product> GetAll()
        {
            using (lppaDbContext db = new lppaDbContext())
            {
                return db.Product;
            }
        }
    }
}
