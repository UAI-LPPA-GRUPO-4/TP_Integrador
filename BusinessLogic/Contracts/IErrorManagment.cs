using Common.Entities;
using System.Collections.Generic;

namespace BusinessLogic.Contracts
{
    public interface IErrorManagment
    {
        IList<Error> GetAllErros();
        void AddError(Error error);
        Error Get(int id);

    }
}
