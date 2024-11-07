using ShapesLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLib.Implementation
{
    /// <summary>
    /// Сервис для работы с геометрическими фигурами.
    /// </summary>
    public class ShapeService : IShapeService
    {
        /// <inheritdoc />
        public double GetCircleArea(double radius)
        {
            var circle = ShapeFactory.CreateCircle(radius);
            return circle.CalculateArea();
        }

        /// <inheritdoc />
        public double GetTriangleArea(double sideA, double sideB, double sideC)
        {
            var triangle = ShapeFactory.CreateTriangle(sideA, sideB, sideC);
            return triangle.CalculateArea();
        }

        /// <inheritdoc />
        public bool IsRightTriangle(double sideA, double sideB, double sideC)
        {
            var triangle = (Triangle)ShapeFactory.CreateTriangle(sideA, sideB, sideC);

            return triangle.IsRightTriangle();
        }
    }
}
