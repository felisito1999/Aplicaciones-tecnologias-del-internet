﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BikeDataLibrary.ServiceModels;

namespace BikeDataLibrary.ServiceViewModels
{
    public class ServiceProductViewModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public short ModelYear { get; set; }
        public decimal ListPrice { get; set; }
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public ServiceBrand Brand { get; set; }
        public ServiceCategory Category { get; set; }
    }
}
