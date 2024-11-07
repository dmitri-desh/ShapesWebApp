using ShapesLib.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLib.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void CalculateArea_ValidSides_ReturnsCorrectArea()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            var triangle = new Triangle(sideA, sideB, sideC);

            // Act
            double area = triangle.CalculateArea();

            // Assert
            Assert.Equal(6, area, 2);
        }

        [Fact]
        public void IsRightTriangle_RightTriangle_ReturnsTrue()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);

            // Act
            bool isRight = triangle.IsRightTriangle();

            // Assert
            Assert.True(isRight);
        }

        [Fact]
        public void IsRightTriangle_NotRightTriangle_ReturnsFalse()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 6);

            // Act
            bool isRight = triangle.IsRightTriangle();

            // Assert
            Assert.False(isRight);
        }

        [Fact]
        public void Constructor_InvalidTriangleSides_ThrowsArgumentException()
        {
            // Arrange
            double sideA = 1;
            double sideB = 2;
            double sideC = 10;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }

        [Fact]
        public void Constructor_NegativeSide_ThrowsArgumentException()
        {
            // Arrange
            double sideA = -3;
            double sideB = 4;
            double sideC = 5;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }
    }
}
