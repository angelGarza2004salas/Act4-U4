using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act4_u4
{
    public class Laptop : IElectronic, IMobileDevice
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string SystemOperating { get; set; }
        public int RAM { get; set; }

        public Laptop (string name, double price, string systemOperating, int ram)
        {
            Name = name;
            Price = price;
            SystemOperating = systemOperating;
            RAM = ram;
        }
    }
}
