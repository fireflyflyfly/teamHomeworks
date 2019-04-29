using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Globalization;

namespace ProgramExtentions2
{
    public class Task3
    {
       public static string rangeStart;
       public static string rangeFinish;
       public static List<int> finalArray = new List<int>();

        public static void RangeCreation()
        {
            int x, y;
            do
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
                    Console.WriteLine("\nYour range must contain 10 or more values. Only digits are allowed. Please try again.");
                }
            }
            while (true);


            for (int i = Convert.ToInt32(rangeStart); i <= Convert.ToInt32(rangeFinish); i++)
                    {
                        if ((i % 3 == 0) && (i % 5 != 0))
                        {
                            finalArray.Add(i);
                        }
                    }

                    finalArray.ForEach(i => Console.WriteLine("{0} ", i));
                    Console.Write("\nThe sum of values dividable by 3 and not dividable by 5 in your array is: " + (finalArray).Sum(i => Convert.ToInt32(i)));
                    
                    }

        }

    }

