﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    class Rectangle : IShape
    {
        public float Width { get; set; }
        public float Height { get; set; }

        public double Area()
        {
            return Width * Height;
        }
    }
}
