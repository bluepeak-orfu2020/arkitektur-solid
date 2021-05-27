﻿using System;
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
            return shape.Area();
        }
    }
}
