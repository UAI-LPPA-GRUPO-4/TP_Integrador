using Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contracts
{
    internal interface IProductDAO
    {        
        void Create(Product p);

        void Update(Product p);

        void Delete(int id);

        Product Get(int id);

        IEnumerable<Product> GetAll();
    }
}
