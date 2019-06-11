using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace TeamHomeworks.Task_3
{
    public class Range
    {
        private static int rangeStart;
        private static int rangeFinish;

        //sets first and last values of the range.
        public static void SetRangeBoundaries()
        {
            while (true)
            {
                Console.WriteLine("Please enter the first number of your range:");
                rangeStart = SetRangeValue();

                Console.WriteLine("\nPlease enter the last number of your range:");
                rangeFinish = SetRangeValue();

                if ((rangeFinish - rangeStart >= 9))
                    break;

                else
                {
                    Console.WriteLine("\nYour range must contain 10 or more values. Only digits are allowed. Please, try again.");
                }
            }
        }

        //general method to get a correct int.
        public static int SetRangeValue()
        {
            int x;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out x))
                    break;

                else
                {
                    Console.WriteLine("\nYour range must contain 10 or more values. Only digits are allowed. Please, try again.");
                }
            }
            return x;
        }

        //fills the array with values dividable by 3 and not dividable by 5.
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

        //prints the sum of all array values.
        public static void SumArrayValues(List<int> array) 
        {
           int sum = array.Sum(i => Convert.ToInt32(i));
            Console.WriteLine("\nThe sum of values dividable by 3 and not dividable by 5 in your array is: " + sum);
        }
    }
}

