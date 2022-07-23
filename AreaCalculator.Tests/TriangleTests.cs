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
    public class TriangleTests
    {
        [TestMethod()]
        public void GetAreaTest_Side5_10point825318return()
        {
            Triangle triangle = new Triangle(5, 5, 5);
            double expected = 10.825318;

            double area = Math.Round(triangle.GetArea(), 6);

            Assert.AreEqual(expected, area);
        }

        [TestMethod()]
        public void Right_angled_triangle_check_result_True()
        {
            Triangle rightAngeledTriangle = new Triangle(546, 728, 910);

            Assert.IsTrue(rightAngeledTriangle.IsRightAngeled);
        }

        [TestMethod()]
        public void Right_angled_triangle_check_result_False()
        {
            Triangle nonRightAngeledTriangle = new Triangle(5, 5, 5);

            Assert.IsFalse(nonRightAngeledTriangle.IsRightAngeled);
        }
    }
}