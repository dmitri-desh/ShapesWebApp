using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLib.Interfaces
{
    /// <summary>
    /// Интерфейс для сервиса, предоставляющего методы вычисления площади и проверки свойств геометрических фигур.
    /// </summary>
    public interface IShapeService
    {
        /// <summary>
        /// Вычисляет площадь круга по радиусу.
        /// </summary>
        /// <param name="radius">Радиус круга.</param>
        /// <returns>Площадь круга.</returns>
        double GetCircleArea(double radius);

        /// <summary>
        /// Вычисляет площадь треугольника по трем сторонам.
        /// </summary>
        /// <param name="sideA">Сторона A треугольника.</param>
        /// <param name="sideB">Сторона B треугольника.</param>
        /// <param name="sideC">Сторона C треугольника.</param>
        /// <returns>Площадь треугольника.</returns>
        double GetTriangleArea(double sideA, double sideB, double sideC);

        /// <summary>
        /// Определяет, является ли треугольник прямоугольным.
        /// </summary>
        /// <param name="sideA">Сторона A треугольника.</param>
        /// <param name="sideB">Сторона B треугольника.</param>
        /// <param name="sideC">Сторона C треугольника.</param>
        /// <returns>True, если треугольник является прямоугольным, иначе False.</returns>
        bool IsRightTriangle(double sideA, double sideB, double sideC);
    }
}
