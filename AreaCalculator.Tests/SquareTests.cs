using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.Tests
{
    [TestClass()]
    public class SquareTests
    {
        [TestMethod()]
        public void GetArea_side5_25return()
        {
            Square square = new Square(5);
            double expected = 25;

            double actual = square.GetArea();

            Assert.AreEqual(expected, actual);
        }
    }
}