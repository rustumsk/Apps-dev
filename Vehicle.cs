using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Vehicle
    {
        string brand;
        string plateNum;
        public Vehicle(string brand, string plateNum)
        {
            this.brand = brand;
            this.plateNum = plateNum;
        }
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public string PlateNum
        {
            get { return plateNum; }
            set { plateNum = value; }
        }
    }
}
