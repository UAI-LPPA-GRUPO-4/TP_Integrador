using Common.Entities;
using DataAccess.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
    public class ProductManagement : IProductManagement
    {
        ProductDB ProDB = new ProductDB();
        ProductFacade facade = new ProductFacade();

        public IList<Common.Entities.Product> GetAllProducts()
        {
            List<DataAccess.Product> listapro = new List<DataAccess.Product>(); //DECLARO UNA LISTA DE PRODUCT DATA ACCESS

            listapro = ProDB.MostrarProductos().ToList(); //LE ASIGNO A LA LISTA TODOS LOS ELEMENTOS

            List<Common.Entities.Product> listaproductos = new List<Common.Entities.Product>(); //DECLARO UNA LISTA DE PRODUCT COMMON

            listaproductos = listapro.Select(x => new Common.Entities.Product() //ASIGNO LOS ELEMENTOS DE LA LISTA DEL PRODCUT DATA ACCESS AL PRODUCT DEL COMMON 
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description,
                ArtistId = x.ArtistId,
                Image = x.Image,
                Price = x.Price,
                QuantitySold = x.QuantitySold,
                AvgStars = x.AvgStars,
                CreatedBy = x.CreatedBy,
                CreatedOn = x.CreatedOn,
                ChangedBy = x.ChangedBy,
                ChangedOn = x.ChangedOn
            }).ToList();


            return listaproductos; //RETORNO LA LISTA
        }

        // todo: dejo opción por si lo queremos trabajar con el patrón Facade
        //public IList<Product> GetAllProducts()
        //{
        //    return (IList<Product>)facade.GetAll();
        //}

        public Common.Entities.Product Get(int id)
        {
            return facade.Get(id);
        }

        public bool AddProduct(Common.Entities.Product prod)
        {
            facade.Create(prod);

            // todo: que el facade devuelva booleano, o hacer void esto directamente
            return true;
        }


        public void Update(Common.Entities.Product prod)
        {
             facade.Update(prod);
        }

        public void Delete(int id)
        {
            facade.Delete(id);
        }
    }
}
