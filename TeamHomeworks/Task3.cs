using System;
using System.Collections;
using System.Collections.Generic;
namespace ProgramExtentions2
{
    public class Task3
    {
       public static int rangeStart;
       public static int rangeFinish;
       public static List<int> finalArray = new List<int>();

        public static void RangeCreation()
        {
            Console.WriteLine("Please enter the first number of your range:");
            rangeStart = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("\nPlease enter the last number of your range:");
            rangeFinish = Convert.ToInt16(Console.ReadLine());

            for (int i = rangeStart; i <= rangeFinish; i++)
            { 
                if ((i % 3 == 0) && (i % 5 != 0))
                {
                    finalArray.Add(i);
                }
            }
            finalArray.ForEach(i => Console.WriteLine("{0} ", i));
        }

    }
}
