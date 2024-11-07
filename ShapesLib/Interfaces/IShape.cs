using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLib.Interfaces
{
    /// <summary>
    /// Определяет интерфейс для фигур, которые могут вычислять свою площадь.
    /// </summary>
    public interface IShape
    {
        /// <summary>
        /// Вычисляет площадь фигуры.
        /// </summary>
        /// <returns>Площадь фигуры.</returns>
        double CalculateArea();
    }
}
