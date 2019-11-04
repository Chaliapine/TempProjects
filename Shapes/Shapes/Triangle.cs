using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Triangle : IShape
    {
        private double _side1;
        private double _side2;
        private double _side3;

        public double Side1 => _side1;
        public double Side2 => _side2;
        public double Side3 => _side3;

        public double P => _side1 + _side2 + _side3;
        public double HalfP => P / 2;

        public Triangle(double side1, double side2, double side3)
        {
            if (side1 <= 0d) throw new ArgumentException("Cannot be less or equal to zero", nameof(side1));
            if (side2 <= 0d) throw new ArgumentException("Cannot be less or equal to zero", nameof(side2));
            if (side3 <= 0d) throw new ArgumentException("Cannot be less or equal to zero", nameof(side3));

            if (side1 + side2 <= side3 ||
                side1 + side3 <= side2 ||
                side2 + side3 <= side1) throw new ArgumentException("Sum of any two sides must be greater than third");

            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }
        
        public double GetArea()
        {
            return Math.Sqrt(HalfP * (HalfP - _side1) * (HalfP - _side2) * (HalfP - _side3));
        }

        public bool IsRight => _side1 * _side1 + _side2 * _side2 == _side3 * _side3 ||
                               _side1 * _side1 + _side3 * _side3 == _side2 * _side2 ||
                               _side2 * _side2 + _side3 * _side3 == _side1 * _side1;
    }
}
