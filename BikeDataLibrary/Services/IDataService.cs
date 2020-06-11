using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeDataLibrary.Services
{
    public interface IDataService<T>
    {
        void Insert(T @object);
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Update(T @object);
        void Delete(int id);
    }
}
