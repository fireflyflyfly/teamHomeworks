using System;
namespace TeamHomeworks.Task_1_2
{
    public class Circle : Figure
    {
        private double _circleRadius;
        public double CircleRadius
        {
            get
            {
                return _circleRadius;
            }

            set
            {
                _circleRadius = value;
            }
        }


        //use in setter 
        public Circle(double radius) 
        {
            CircleRadius = radius;
        }

        public override double CalculateArea()
        {
            area = Math.Round((PI * (Math.Pow(CircleRadius, 2))), 2);
            Console.WriteLine("The area of your circle is: " + area);
            return area;
        }
    }
}
