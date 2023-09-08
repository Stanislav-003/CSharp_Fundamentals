using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeWork10;

namespace TriangleTest
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void TestTrianglePerimeter_3Points_ReturnCorrectPerimeter()
        {
            Triangle triangle = new Triangle(new Point(2, 6), new Point(4, 1), new Point(1, 7));

            double rightPerimeter = 13.5;
            double perimeter = triangle.Perimeter();

            Assert.AreEqual(rightPerimeter, perimeter, 0.1);
        }

        [TestMethod]
        public void TestTriangleSquare_3Points_ReturnCorrectSquare()
        {
            Triangle triangle = new Triangle(new Point(2, 6), new Point(4, 1), new Point(1, 7));

            double rightSquare = 5.2;
            double square = triangle.Square();

            Assert.AreEqual(rightSquare, square, 0.1);
        }

        [TestMethod]
        public void InformationAboutTriangle()
        {
            Triangle triangle = new Triangle(new Point(2, 6), new Point(4, 1), new Point(1, 7));

            string rightMessage = "Трикутник 1" +
                                  "Вершини трикутника: (2,6), (4,1), (1,7)" +
                                  "Периметр трикутника: 13,50758230200697" +
                                  "Площа трикутника: 5,202965715096142";

            string message = $"Трикутник {triangle.TriangleNumber}" +
                             $"Вершини трикутника: {new Point(2, 6)}, {new Point(4, 1)}, {new Point(1, 7)}" +
                             $"Периметр трикутника: {triangle.Perimeter()}" +
                             $"Площа трикутника: {triangle.Square()}";

            Assert.AreEqual(rightMessage, message);
        }

        [TestMethod]
        public void InformationAboutPoint()
        {
            Point point = new Point(2, 6);

            string rightCoordinates = "(2,6)";
            string сoordinates = point.ToString();

            Assert.AreEqual(rightCoordinates, сoordinates);
        }
    }
}
