using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace TeamHomeworks.Task_4
{
    public class Task_4
    {
        //approach #1
        public static void Reverse()
        {
            Console.WriteLine("Please enter your word: ");
            string initialString = Console.ReadLine();
            char[] characters = initialString.ToCharArray();
            if (characters.SequenceEqual(characters.Reverse()) == true)
            {
                Console.WriteLine("\nYour word is a palindrome :)");
            }
            else
            {
                Console.WriteLine("\nYour is not a palindrome :(");
            }
        }

        //approach #2

        public static void PalindromeCheck()
        {
            CompareStrings(CroppString());
        }

        //leave everything but latin and upper quotes, make a lot of spaces one space
        public static char[] CroppString()
        {
            Console.WriteLine("\nPlease enter a word or a phrase:");
            char[] characters = Regex.Replace(Console.ReadLine().ToLower(), @"[^a-zA-Z""]+|\s+", " ").Trim().ToCharArray();

            foreach (char ch in characters)
            {
                Console.WriteLine(ch.ToString());
            }
            return characters;
        }

        public static void CompareStrings(char[] array)
        {

            List<char> reversedArray = new List<char>();

            for (int i = array.Length - 1; i >= 0; i--)
            {
                reversedArray.Add(array[i]);
            }

            if (reversedArray.SequenceEqual(array))
            {
                Console.WriteLine("That stuff you entered is a palyndrome!");
            }

            else Console.WriteLine("\nYour word or phrase is not a palindrome.");
        }
    }
}
