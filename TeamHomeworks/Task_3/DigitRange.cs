using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace TeamHomeworks.Task_3
{
    public class Range
    {
        private static string rangeStart;
        private static string rangeFinish;

        //sets first and last values of the range
        public static void SetRangeBoundaries()
        {
            int x, y;
            while (true)
            {
                Console.WriteLine("Please enter the first number of your range:");
                rangeStart = Console.ReadLine();

                Console.WriteLine("\nPlease enter the last number of your range:");
                rangeFinish = Console.ReadLine();

                if (int.TryParse(rangeStart, out x) && int.TryParse(rangeFinish, out y)
                    && (Convert.ToInt32(rangeFinish) - Convert.ToInt32(rangeStart) >= 9))
                    break;

                else
                {
                    Console.WriteLine("\nYour range must contain 10 or more values. Only digits are allowed. Please, try again.");
                }
            }
        }

        //fills the array with values dividable by 3 and not dividable by 5
        public static List<int> FillRange()
        {
            List<int> finalArray = new List<int>();

            for (int i = Convert.ToInt32(rangeStart); i <= Convert.ToInt32(rangeFinish); i++)
            {
                if ((i % 3 == 0) && (i % 5 != 0))
                {
                    finalArray.Add(i);
                }
            }
            return finalArray;
        }

        // just for testing purposes, prints all array values 
        //public void GetFinalValues() 
        //{
        //    finalArray.ForEach(i => Console.WriteLine("{0}", i));
        //}

        //prints the sum of all array values
        public static void SumArrayValues(List<int> array) 
        {
           int sum = (array).Sum(i => Convert.ToInt32(i));
            Console.WriteLine("\nThe sum of values dividable by 3 and not dividable by 5 in your array is: " + sum);
        }




    }
}

