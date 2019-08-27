using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vehicle_testing_station
{
    public class ServiceWrap : IService
    {
        private Service _service;

        public ServiceWrap(string carServiceName, decimal carServicePrice)
        {
            _service = new Service(carServiceName, carServicePrice);
        }

        string IService.GetServiceName()
        {
            return _service.ServiceName;
        }

        decimal IService.GetServicePrice()
        {
            return _service.ServicePrice;
        }
    }
}