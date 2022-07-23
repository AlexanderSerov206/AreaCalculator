using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    /// <summary>
    /// Правильный многоугольник с произвольным количеством сторон. Позволяет реализовывать различные фигуры.
    /// </summary>
    public abstract class RegularPolygon : IShape
    {
        public int SidesCount { get; private set; }
        private double Side { get; set; }

        public RegularPolygon(double side, int sidesCount)
        {
            SidesCount = sidesCount;
            Side = side;
        }

        /// <summary>
        /// Расчитывает площадь правильного многоугольника.
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            return Math.Round(SidesCount * Math.Pow(Side, 2) / 4 * Math.Tan(Math.PI / SidesCount),5);            
        }
    }
}
