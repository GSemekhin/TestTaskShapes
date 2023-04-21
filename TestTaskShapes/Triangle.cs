using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskShapes
{
    public class Triangle : IShape
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public double CalculateArea()
        {
            double p = (_sideA + _sideB + _sideC) / 2;
            return Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
        }

        public double CalculatePerimeter()
        {
            return _sideA + _sideB + _sideC;
        }
        public bool IsRightTriangle()
        {
            return _sideA * _sideA + _sideB * _sideB == _sideC * _sideC ||
                   _sideB * _sideB + _sideC * _sideC == _sideA * _sideA ||
                   _sideC * _sideC + _sideA * _sideA == _sideB * _sideB;
        }
    }
}
