using System;
namespace TeamHomeworks.Task_1_2
{
    public class FigureComparision
    {
    
        public static void CreatAndCompareFigures()
        {
            Console.WriteLine("\nPlease enter the radius of your circle:");
            Circle circle = new Circle(Helpers.GetFigureDimensions());

            Console.WriteLine("\nPlease nter the length of the side of your square:");
            Square square = new Square(Helpers.GetFigureDimensions());

            circle.CalculateArea();
            square.CalculateArea();

            Helpers.FitSquareIntoCircle(square, circle);
            Helpers.FitCirleIntoSquare(circle, square);

        }

    }
}
