using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vehicle_testing_station
{
    public abstract class Station
    {
        private string _address;
        private string _contactNum;
        private string _name;

        protected string Address
        {
            get => _address;
            set
            {
                _address = value;
            }
        }

        protected string ContactNum
        {
            get => _contactNum;
            set
            {
                _contactNum = value;
            }
        }

        protected string Name
        {
            get => _name;
            set
            {
                _name = value;
            }
        }


        public abstract string GetStationDetails();
    }
}