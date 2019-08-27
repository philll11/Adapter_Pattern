using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vehicle_testing_station
{
    public class Service
    {
        private string _serviceName;
        private decimal _servicePrice;

        public Service(string serviceName, decimal servicePrice)
        {
            _serviceName = serviceName;
            _servicePrice = servicePrice;
        }

        public string ServiceName
        {
            get => _serviceName;
        }
        public decimal ServicePrice
        {
            get => _servicePrice;
        }
    }
}