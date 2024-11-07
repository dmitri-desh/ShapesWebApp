using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLib.Implementation
{
    /// <summary>
    /// Представляет круг с возможностью вычисления площади.
    /// </summary>
    public class Circle : Shape
    {
        /// <summary>
        /// Радиус круга.
        /// </summary>
        public double Radius { get; }

        /// <summary>
        /// Инициализирует экземпляр круга с заданным радиусом.
        /// </summary>
        /// <param name="radius">Радиус круга.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если радиус неположительный.</exception>
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Radius should be > 0");
            Radius = radius;
        }

        /// <inheritdoc />
        public override double CalculateArea() => Math.PI * Math.Pow(Radius, 2);
    }
}
