using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeDataLibrary.Services
{
    public interface IModelViewModelConverter<T, T1>
        where T : class
        where T1 : class
    {
        T1 ConvertModelToViewModel(T model);
        T ConvertViewModelToModel(T1 viewModel);
        IEnumerable<T1> ConvertModelListToViewModelCollection(IEnumerable<T> modelCollection);
        IEnumerable<T> ConvertViewModelToModelCollection(IEnumerable<T1> viewModelCollection);
    }
}
