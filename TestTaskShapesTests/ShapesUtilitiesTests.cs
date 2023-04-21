using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestTaskShapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskShapes.Tests
{
    [TestClass()]
    public class ShapesUtilitiesTests
    {
        [TestMethod()]
        public void Circle_Area_CalculatedCorrectly()
        {
            // Arrange
            double radius = 5.0;
            IShape circle = new Circle(radius);

            // Act
            double area = circle.CalculateArea();

            // Assert
            Assert.AreEqual(Math.PI * radius * radius, area);
        }
        [TestMethod]
        public void Circle_Perimeter_CalculatedCorrectly()
        {
            // Arrange
            double radius = 5.0;
            IShape circle = new Circle(radius);

            // Act
            double perimeter = circle.CalculatePerimeter();

            // Assert
            Assert.AreEqual(2 * Math.PI * radius, perimeter);
        }

        [TestMethod]
        public void Triangle_Area_CalculatedCorrectly()
        {
            // Arrange
            double sideA = 3.0;
            double sideB = 4.0;
            double sideC = 5.0;
            IShape triangle = new Triangle(sideA, sideB, sideC);

            // Act
            double area = triangle.CalculateArea();

            // Assert
            Assert.AreEqual(6.0, area);
        }

        [TestMethod]
        public void Triangle_Perimeter_CalculatedCorrectly()
        {
            // Arrange
            double sideA = 3.0;
            double sideB = 4.0;
            double sideC = 5.0;
            IShape triangle = new Triangle(sideA, sideB, sideC);

            // Act
            double perimeter = triangle.CalculatePerimeter();

            // Assert
            Assert.AreEqual(sideA + sideB + sideC, perimeter);
        }

        [TestMethod]
        public void Triangle_IsRightTriangle_True()
        {
            // Arrange
            double sideA = 3.0;
            double sideB = 4.0;
            double sideC = 5.0;
            IShape triangle = new Triangle(sideA, sideB, sideC);

            // Act
            bool isRightTriangle = ((Triangle)triangle).IsRightTriangle();

            // Assert
            Assert.IsTrue(isRightTriangle);
        }

        [TestMethod]
        public void Triangle_IsRightTriangle_False()
        {
            // Arrange
            double sideA = 2.0;
            double sideB = 3.0;
            double sideC = 4.0;
            IShape triangle = new Triangle(sideA, sideB, sideC);

            // Act
            bool isRightTriangle = ((Triangle)triangle).IsRightTriangle();

            // Assert
            Assert.IsFalse(isRightTriangle);
        }
    }
}