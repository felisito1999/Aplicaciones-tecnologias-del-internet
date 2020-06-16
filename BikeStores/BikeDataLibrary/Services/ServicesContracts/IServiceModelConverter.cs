using BikeDataLibrary.ServiceModels;
using BikeDataLibrary.BikeStoresData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeDataLibrary.Services.ServicesContracts
{
    public interface IServiceModelConverter<T, T1>
        where T : class
        where T1 : class
    {
        T ConvertModelToServiceModel(T1 model);
        T1 ConvertServiceModelToModel(T serviceModel);
        List<T> ConvertModelCollectionToServiceModelCollection(List<T1> modelCollection);
        List<T1> ConvertServiceModelCollecitonToModelCollection(List<T> serviceModelCollection);
    }
}
