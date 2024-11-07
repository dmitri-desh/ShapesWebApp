using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLib.Implementation
{
    /// <summary>
    /// Представляет треугольник с возможностью вычисления площади и проверки на прямоугольность.
    /// </summary>
    public class Triangle : Shape
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        /// <summary>
        /// Инициализирует экземпляр треугольника с заданными сторонами.
        /// </summary>
        /// <param name="sideA">Сторона A треугольника.</param>
        /// <param name="sideB">Сторона B треугольника.</param>
        /// <param name="sideC">Сторона C треугольника.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если стороны не образуют допустимый треугольник.</exception>
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                throw new ArgumentException("All sides should be > 0");

            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
                throw new ArgumentException("This triangle isn't exists");

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        /// <inheritdoc />
        public override double CalculateArea()
        {
            double p = (SideA + SideB + SideC) / 2;

            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        /// <summary>
        /// Проверяет, является ли треугольник прямоугольным.
        /// </summary>
        /// <returns>True, если треугольник прямоугольный, иначе False.</returns>
        public bool IsRightTriangle()
        {
            const double E = 0.0001;

            var sides = new[] { SideA, SideB, SideC };
            Array.Sort(sides);
            
            return Math.Abs(Math.Pow(sides[2], 2) - Math.Pow(sides[0], 2) - Math.Pow(sides[1], 2)) < E;
        }
    }
}
