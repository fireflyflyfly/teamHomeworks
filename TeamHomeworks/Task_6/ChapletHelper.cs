using System;
namespace TeamHomeworks.Task_6
{
    public class ChapletHelper
    {
        public static int GetChapletLength()
        {
            Console.WriteLine("Please enter the desired length of your chaplet:");
            if (int.TryParse(Console.ReadLine(), out int length))
            {
                return length;
            }
            else
            {
                Console.WriteLine("You have tried the forbidden and now your length is set to 10.");
                return 10;
            }
        }
    }
}
