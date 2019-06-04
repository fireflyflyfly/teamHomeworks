using System;
namespace TeamHomeworks.Task1
{
    public class Square : Figure
    {
        public readonly double squareSide;
        public double squareArea;

        public Square() 
        {
            Console.WriteLine("\nPlease nter the length of the side of your square:");
            squareSide = GetFigureDimensions();
        }

        public override double CalculateArea()
        {
            squareArea = Math.Round((Math.Pow(squareSide, 2)), 2);
            Console.WriteLine("\nThe area of your square Is: " + squareArea);
            return squareArea;
        }

        public void FitCirleIntoSquare(Circle c) 
        {
            if (squareSide >= c.CircleRadius * 2)
            {
                Console.WriteLine("\nYour circle fits inside your square!");
            }

            else 
            { 
            Console.WriteLine("\nYour circle does not fit inside your square."); 
            }
        }
    }
}
