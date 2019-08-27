using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vehicle_testing_station
{
    public interface IService
    {
        string GetServiceName();
        decimal GetServicePrice();
    }
}