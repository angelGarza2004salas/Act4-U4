using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act4_u4
{
    public class Television : IElectronic
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Inches { get; set; }

        public Television(string name, double price, int inches)
        {
            Name = name;
            Price = price;
            Inches = inches;
        }
    }
}
