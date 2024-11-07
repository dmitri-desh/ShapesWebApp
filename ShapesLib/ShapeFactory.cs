using ShapesLib.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLib
{
    /// <summary>
    /// Фабрика для создания объектов фигур.
    /// </summary>
    public static class ShapeFactory
    {
        public static Shape CreateCircle(double radius) => new Circle(radius);

        public static Shape CreateTriangle(double sideA, double sideB, double sideC) => new Triangle(sideA, sideB, sideC);
    }
}
