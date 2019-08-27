using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vehicle_testing_station
{
    public class TestingStation : Station
    {
        private List<IService> _services;

        private static int _totalNumberOfServices;
        private static decimal _totalCostOfServices;
        public TestingStation(string address, string contactNum, string name)
        {
            Address = address;
            ContactNum = contactNum;
            Name = name;
            _totalCostOfServices = 0;
            _services = new List<IService>();
        }
        public override string GetStationDetails()
        {
            return Name + "\n" + ContactNum + "\n" + Address;
        }
        public static int TotalNumberOfServices()
        {
            return _totalNumberOfServices;
        }
        public void IncreaseTotalNumberOfServices()
        {
            ++_totalNumberOfServices;
        }
        public static void AddToTotal(decimal price)
        {
            _totalCostOfServices += price;
        }
        public static decimal GetTotalPrice()
        {
            return _totalCostOfServices;
        }
        public void AddService(IService obj)
        {
            IncreaseTotalNumberOfServices();
            _services.Add(obj);
        }
        public List<IService> GetServicesList()
        {
            return _services;
        }
        public int ServicesLength()
        {
            return _services.Count;
        }
        public IService TopOfServicesList()
        {
            return _services.Last<IService>();
        }

    }
}