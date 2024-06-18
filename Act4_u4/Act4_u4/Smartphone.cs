using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act4_u4
{
    public class Smartphone : IElectronic, IMobileDevice
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string SystemOperating { get; set; }
        public int Camera { get; set; }


        public Smartphone(string name, double price, string systemOperating, int camera)
        {
            Name = name;
            Price = price;
            SystemOperating = systemOperating;
            Camera = camera;
        }
    }
}
