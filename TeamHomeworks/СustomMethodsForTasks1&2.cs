using System;
namespace ProgramExtentions
{
    public static class Extentions
    {
        public const double PI = 3.14159265359;
        public static double squareSide, squareArea;
        public static double circleRadius, circleArea;


        public static double CalculateSquareArea()
        {
            Console.WriteLine("Please enter the length of a side of your square and hit Enter: ");
            squareSide = Convert.ToDouble(Console.ReadLine());
            squareArea = Math.Pow (squareSide, 2);
            Console.WriteLine("\nArea of Square: " + squareArea + "\nPress Enter again to continue...");
            Console.ReadKey();
            return squareArea;
        }

        public static double CircleArea() 
        {

            Console.WriteLine("\nPlease enter the radius of your circle and hit Enter: ");
            circleRadius = double.Parse(Console.ReadLine());
            circleArea = PI * (Math.Pow(circleRadius, 2));
            Console.WriteLine("The Area of your circle is: " + circleArea);
            return circleArea;
        }

        public static void CircleInYourSquare() 
        {
            if (squareSide >= circleRadius * 2)
                Console.WriteLine("\nYour circle fits inside your square!");
            else Console.WriteLine("\nYour circle does not fit inside your square.");
        }

        public static void SquareInYourCircle() 
        {
            if (squareSide / Math.Sqrt(2) <= circleRadius)
                Console.WriteLine("\nYour square fits inside your circle!");
            else Console.WriteLine("\nYour square does not fit inside your circle.");
        }
}
}
