using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace DataAccess
{
    public class ProductDB
    {
        DBEntities modelDB = new DBEntities();

        public bool Guardar(Product product)
        {
            modelDB.Product.Add(product); //Agrega un nuevo elemento a la tabla producto
            modelDB.SaveChanges();  //guarda todos los cambios en la base
            return true;    //retorna verdadero

        }

        public List<Product>MostrarProductos()
        {
            var query = (from e in modelDB.Product select e); //Select de todos los productos a la base (LINQ)

            return query.ToList();

        }

    }
}
