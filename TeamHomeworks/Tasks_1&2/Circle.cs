using System;
namespace TeamHomeworks.Task1
{
    public class Circle : Figure
    {
        public readonly double circleRadius;
        public double circleArea;

        public Circle(double radius) 
        {
            circleRadius = radius;
        }

        public override double CalculateArea()
        {
            circleArea = Math.Round((PI * (Math.Pow(circleRadius, 2))), 2);
            Console.WriteLine("The area of your circle is: " + circleArea);
            return circleArea;
        }

        public void FitSquareIntoCircle(Square s)
        {
            if (s.squareSide / Math.Sqrt(2) <= circleRadius)
            {
                Console.WriteLine("\nYour square fits inside your circle!");
            }

            else
            {
                Console.WriteLine("\nYour square does not fit inside your circle.");
            }

        }
    }
}
