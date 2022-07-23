using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    /// <summary>
    /// Треугольный, который создаётся путём объявления длин его сторон.
    /// </summary>
    public class Triangle : IShape
    {
        public bool IsRightAngeled { get; private set; }
        public double SideA { get; private set; }
        public double SideB { get; private set; }
        public double SideC { get; private set; }

        /// <summary>
        /// Конструктор, в котором проводится проверка на возможность создания треугольника и на то, является ли треугольник прямоугольным.
        /// </summary>
        /// <param name="sideA"></param>
        /// <param name="sideB"></param>
        /// <param name="sideC"></param>
        /// <exception cref="Exception"></exception>
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (!(sideA + sideB > sideC))
                throw new Exception("Сторона \"C\" больше или равна сумме сторон \"A\" и \"B\". Такой трегульник невозможен.");

            if (!(sideA + sideC > sideB))
                throw new Exception("Сторона \"B\" больше или равна сумме сторон \"A\" и \"C\". Такой трегульник невозможен.");

            if (!(sideB + sideC > sideA))
                throw new Exception("Сторона \"A\" больше или равна сумме сторон \"B\" и \"C\". Такой трегульник невозможен.");

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;

            IsRightAngeled = CheckRightAngeled();
        }

        /// <summary>
        /// Расчёт площади треугольника по формуле Герона.
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            double halfPerimeter = (SideA + SideB + SideC) / 2d;

            return Math.Sqrt(halfPerimeter * (halfPerimeter - SideA) * (halfPerimeter - SideB) * (halfPerimeter - SideC));
        }

        /// <summary>
        /// Проверяет, является ли треугольник прямоугольным.
        /// </summary>
        /// <returns></returns>
        private bool CheckRightAngeled()
        {
            List<double> sides = new List<double>() { SideA, SideB, SideC };

            double largestSide = sides.Max();

            sides.Remove(largestSide);

            if (Math.Pow(largestSide, 2) == sides.Select(x => Math.Pow(x, 2)).Sum())
            {
                return true;
            }

            return false;
        }
    }
}
