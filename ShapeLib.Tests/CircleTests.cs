using ShapesLib.Implementation;

namespace ShapeLib.Tests
{
    public class CircleTests
    {
        [Fact]
        public void CalculateArea_ValidRadius_ReturnsCorrectArea()
        {
            // Arrange
            double radius = 5;
            var circle = new Circle(radius);

            // Act
            double area = circle.CalculateArea();

            // Assert
            Assert.Equal(78.54, area, 2);
        }

        [Fact]
        public void Constructor_NegativeRadius_ThrowsArgumentException()
        {
            // Arrange
            double radius = -5;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }
    }
}