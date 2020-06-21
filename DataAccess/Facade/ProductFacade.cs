using DataAccess.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Facade
{
    public class ProductFacade : IFacadeCRUD<Common.Entities.Product>
    {
        private ProductDAOSql implementation; // todo: esto podría ser un factory

        public ProductFacade() {
            implementation = new ProductDAOSql();
        }

        public void Create(Common.Entities.Product p)
        {
            implementation.Create(productToDataEntityProduct(p));
        }

        public void Update(Common.Entities.Product p)
        {
            implementation.Update(productToDataEntityProduct(p));
        }

        public void Delete(Common.Entities.Product p)
        {
            implementation.Delete(productToDataEntityProduct(p));
        }

        public Common.Entities.Product Get(int id)
        {
            return dataEntityProductToProduct(implementation.Get(id));
        }

        public IEnumerable<Common.Entities.Product> GetAll()
        {
            lppaDbContext db = new lppaDbContext();
            

            List<Common.Entities.Product> products = new List<Common.Entities.Product>();
            //IEnumerable<Product> dataEntityProducts = implementation.GetAll();
            IEnumerable<Product> dataEntityProducts = db.Product;

            foreach (Product e in dataEntityProducts)
            {
                products.Add(dataEntityProductToProduct(e));
            }

            return products;
        }

        // TODO: estos mappers no deberían estar en Facade, tal vez debería ser responsabilidad de la implementación
        private Product productToDataEntityProduct(Common.Entities.Product p)
        {
            Product entity = new Product();

            entity.ArtistId = p.ArtistId;
            entity.AvgStars = p.ArtistId;
            entity.ChangedBy = p.ChangedBy;
            entity.ChangedOn = p.ChangedOn;
            entity.CreatedBy = p.CreatedBy;
            entity.Description = p.Description;
            entity.Image = p.Image;
            entity.Price = p.Price;
            entity.Title = p.Title;

            return entity;
        }

        private Common.Entities.Product dataEntityProductToProduct(Product entity)
        {
            Common.Entities.Product product = new Common.Entities.Product();

            product.ArtistId = entity.ArtistId;
            product.AvgStars = entity.ArtistId;
            product.ChangedBy = entity.ChangedBy;
            product.ChangedOn = entity.ChangedOn;
            product.CreatedBy = entity.CreatedBy;
            product.Description = entity.Description;
            product.Image = entity.Image;
            product.Price = entity.Price;
            product.Title = entity.Title;

            return product;
        }
    }
}
