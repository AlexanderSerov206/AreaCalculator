namespace AreaCalculator.Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void GetArea_10radius_314return()
        {
            double radius = 10;
            Circle circle = new Circle(radius);
            double expected = 314;

            double actual = Math.Round(circle.GetArea());

            Assert.AreEqual(expected, actual);
        }
    }
}