using Common.Entities;
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

        public bool AddProduct(Common.Entities.Product prod)
        {
            DataAccess.Product pro = new DataAccess.Product();

            //ASIGNACIONES DE PROPIEDADES
            pro.ArtistId = prod.ArtistId;
            pro.AvgStars = prod.ArtistId;
            pro.ChangedBy = prod.ChangedBy;
            pro.ChangedOn = prod.ChangedOn;
            pro.CreatedBy = prod.CreatedBy;
            pro.Description = prod.Description;
            pro.Image = prod.Image;
            pro.Price = prod.Price;
            pro.Title = prod.Title;
            
            return ProDB.Guardar(pro);
        }
    }

    //public class Repo
    //{
    //    
    //    private static IList<Common.Entities.Product> data = new List<Common.Entities.Product>();

    //    public static IList<Common.Entities.Product> GetAll()
    //    {
    //        return data;
    //    }

    //    public void Add(Common.Entities.Product prod)
    //    {
    //        data.Add(prod);
    //    }
    //}
}
