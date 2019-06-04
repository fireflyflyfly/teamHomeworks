using System;
namespace TeamHomeworks.Task1
{
    public abstract class Figure
    {
        public const double PI = 3.14159265359;
        public abstract double CalculateArea();

        public static double GetFigureDimensions()
        {
            int i = 3;
            double x = 0;
            while (i > 0) 
            {
                if (double.TryParse(Console.ReadLine(), out x) && x > 0)
                {
                    break;
                }
                else 
                {
                    Console.WriteLine($"\nOnly gigits equal or higer than 1 are allowed. Please try again. You have {(i-1)} attempts left.");
                    i--; 
                }
            }

            if (i == 0) 
            { 
                x = Randomizer.SetRandomValue();
                Console.WriteLine("\nYou are out of attempts. The value has been automatically set to :" + x);
            }
            return x;
        }

        //public static Figure CreateCircle() 
        //{
        //    Console.WriteLine("\nPlease nter the radius of your circle:");
        //    return new Circle(Figure.GetFigureDimensions());
        //}

        //public static Figure CreateSquare() 
        //{
        //    Console.WriteLine("\nPlease nter the length of the side of your square:");
        //    return new Square(Figure.GetFigureDimensions());
        //}
    }
}
