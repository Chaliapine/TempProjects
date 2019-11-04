using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Circle : IShape
    {
        private double _radius;
        public double Radius => _radius;

        public Circle(double radius)
        {
            if (radius <= 0d) throw new ArgumentException("radius cannot be less or equal to zero", nameof(radius));
            _radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * _radius * _radius;
        }
    }
}
