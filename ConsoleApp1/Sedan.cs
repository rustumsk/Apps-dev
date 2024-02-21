using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Sedan : Vehicle
    {
        string type;
        public Sedan(string brand, string plateNum, string type) : base(brand, plateNum)
        {
            this.type = type;
        }
        public string Type
        {
            get { return type; }

            set { type = value; }
        }
        public enum Amounts
        {
            value = 30,
            perHour = 15,
        }
    }
}
