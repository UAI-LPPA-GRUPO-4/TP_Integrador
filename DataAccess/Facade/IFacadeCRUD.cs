using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Facade
{
    internal interface IFacadeCRUD<T>
    {
        void Create(T obj);

        void Update(T obj);

        void Delete(int id);

        T Get(int id);

        IEnumerable<T> GetAll();
    }
}
