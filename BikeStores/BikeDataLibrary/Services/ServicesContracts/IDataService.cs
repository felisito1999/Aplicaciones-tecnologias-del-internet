using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeDataLibrary.Services.ServicesContracts
{
    public interface IDataService<T> where T : class
    {
        void Insert(T @object);
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Update(T @object);
        void Delete(int id);
    }
}
