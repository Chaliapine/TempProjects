using Shapes;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ShapesTests
{
    public class CircleTests
    {
        [Theory]
        [InlineData(-10d)]
        [InlineData(0d)]
        public void ShouldThrowException(double radius)
        {
            Assert.Throws<ArgumentException>("radius", ()=> new Circle(radius));
        }

        [Theory]
        [InlineData(3d, 28.2743d, 4)]
        [InlineData(1d, 3.1416d, 4)]
        public void ShouldCalcArea(double radius, double area, int precision)
        {
            var circle = new Circle(radius);
            Assert.Equal(area, circle.GetArea(), precision);
        }
    }
}
