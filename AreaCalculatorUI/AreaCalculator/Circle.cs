using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public class Circle : IShape
    {
        public double Radius { get; private set; }
        public Circle(double radius)
        {
            Radius = radius;
        }

        /// <summary>
        /// Высчитывает площадь круга по радиусу.
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
