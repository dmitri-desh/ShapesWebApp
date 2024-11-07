using ShapesLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLib.Implementation
{
    public abstract class Shape : IShape
    {
        public abstract double CalculateArea();
    }
}
