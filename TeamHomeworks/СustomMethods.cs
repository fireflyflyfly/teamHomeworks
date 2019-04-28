using System;
namespace ProgramExtentions
{
    public static class Extentions
    {
        public const double PI = 3.14159265359;
        public static double side, area; 

        public static void SquareArea()
        {
            Console.WriteLine("Please enter the Length of Side and hit Enter : ");
            side = Convert.ToDouble(Console.ReadLine());
            area = side * side;
            Console.WriteLine("\nArea of Square: " + area);
            Console.ReadKey();
        }

        public static void CircleArea() 
        {

            Console.WriteLine("\nPlease enter the radius of your circle and hit Enter: ");
            double radius = double.Parse(Console.ReadLine());
            area = PI * (Math.Pow(radius, 2));
            Console.WriteLine("The Area of your circle is: {0:0.00}", area);
        }
}
}
