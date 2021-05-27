using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    class Geometry
    {
        public double CalculateArea(IShape shape)
        {
            if (shape is Rectangle)
            {
                Rectangle rec = (Rectangle)shape;
                return rec.Width * rec.Height;
            }
            else if (shape is Circle)
            {
                Circle c = (Circle)shape;
                return Math.Pow(c.Radius, 2) * Math.PI;
            }
            else
            {
                throw new Exception("Unknown shape");
            }
        }
    }
}
