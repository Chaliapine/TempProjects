using Shapes;
using System;
using Xunit;

namespace ShapesTests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(3d, 4d, 5d, true)]
        [InlineData(3d, 5d, 4d, true)]
        [InlineData(3d, 4d, 6d, false)]
        public void IsRightTests(double side1, double side2, double side3, bool isRight)
        {
            Assert.Equal(isRight, new Triangle(side1, side2, side3).IsRight);
        }
        [Fact]
        public void ShouldThrowException1()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(3d, 4d, 7d));
        }

        [Fact]
        public void ShouldThrowException2()
        {
            Assert.Throws<ArgumentException>("side3", () => new Triangle(3d, 4d, -1d));
        }

        [Theory]
        [InlineData(3d, 4d, 5d, 6d, 6)]
        public void ShouldCalcArea(double side1, double side2, double side3, double area, int precision)
        {
            var triangle = new Triangle(side1, side2, side3);
            Assert.Equal(area, triangle.GetArea(), precision);
        }
    }
}
