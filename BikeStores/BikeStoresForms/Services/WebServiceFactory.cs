using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BikeStoresForms.BikeStoresWebService;


namespace BikeStoresForms.Services
{
    public static class WebServiceFactory
    {
        public static BikeStoresWebServiceSoapClient GetBikeStoresClient()
        {
            return new BikeStoresWebServiceSoapClient();
        }
    }
}
