using System;
using System.Collections.Generic;
using System.Linq;
namespace ProgramExtensions4
{
    public class Task_4
    {

        public static void Reverser() 
        {
            Console.WriteLine("Please enter your word: ");
            string x = Console.ReadLine();
            char[] characters = x.ToCharArray();
            if (characters.SequenceEqual(characters.Reverse())== true) 
            {
                Console.WriteLine("\nYour word is a palindrome :)");
            }
            else 
            {
                Console.WriteLine("\nYour is not a palindrome :(");
            }
        }
}
}