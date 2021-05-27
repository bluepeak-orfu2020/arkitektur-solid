using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    class Circle : IShape
    {
        public float Radius { get; set; }

        public double Area()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }
    }
}
