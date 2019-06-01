using System;
namespace TeamHomeworks.Task1
{
    public class FigureComparision
    {
    
        public static void CreateFigures()
        {
            Circle circle = (Circle)Figure.CreateCircle();
            Square square = (Square)Figure.CreateSquare();

            circle.CalculateArea();
            square.CalculateArea();

           circle.FitSquareIntoCircle(square);
           square.FitCirleIntoSquare(circle);
        }

    }
}
