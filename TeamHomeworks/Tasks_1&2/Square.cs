using System;
namespace TeamHomeworks.Task_1_2
{
    public class Square : Figure
    {
        private double _squareSide;
        public double SquareSide
        {
            get
            {
                return _squareSide;
            }

            set
            {
                _squareSide = value;
            }

        }

        public Square(double side) 
        {
            SquareSide = side;
        }

        public override double CalculateArea()
        {
            area = Math.Round((Math.Pow(SquareSide, 2)), 2);
            Console.WriteLine("\nThe area of your square Is: " + area);
            return area;
        }
    }
}
