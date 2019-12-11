using System;
namespace MindBoxTask.Shapes
{
    public class Triangle : IShape
    {
        private readonly int _sideOne;
        private readonly int _sideTwo;
        private readonly int _sideThree;

        public Triangle(int sideOne, int sideTwo, int sideThree)
        {
            _sideOne = sideOne;
            _sideTwo = sideTwo;
            _sideThree = sideThree;
        }

        public double CalculateArea()
        {
            var p = (_sideOne + _sideTwo + _sideThree) / 2;
            return Math.Sqrt(p * (p - _sideOne) * (p - _sideTwo) * (p - _sideThree));
        }

        public bool IsRightAngled()
        {
            var sideOneSqr = _sideOne * _sideOne;
            var sideTwoSqr = _sideTwo * _sideTwo;
            var sideThreeSqr = _sideThree * _sideThree;
            if (sideOneSqr == sideTwoSqr + sideThreeSqr
                || sideTwoSqr == sideOneSqr + sideThreeSqr
                || sideThreeSqr == sideTwoSqr + sideOneSqr)
            {
                return true;
            }

            return false;
        }
    }
}
