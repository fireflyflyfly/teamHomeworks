using System;
namespace TeamHomeworks.Task1
{
    public class FigureComparision
    {
    
        public static void CreatAndCompareFigures()
        {
            Circle circle = new Circle();
            Square square = new Square();

            circle.CalculateArea();
            square.CalculateArea();

           circle.FitSquareIntoCircle(square);
           square.FitCirleIntoSquare(circle);
        }

    }
}
