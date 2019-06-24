using System;
using System.Collections.Generic;
using System.IO;

namespace TeamHomeworks.Task_7
{
    public class CountriesDictionary
    {
        public static void GetDictionary() 
        {
            Dictionary<int, string> CountriesDic = new Dictionary<int, string>();
            string[] lines = File.ReadAllLines(@"/Users/yegorabramenkov/Documents/VisualStudiFiles/CountryList.txt");
            foreach (string country in lines) 
            {
                int i = 1; 
                CountriesDic.Add(i, country);
                i++;

                Console.WriteLine(CountriesDic[i]);
            }
        }
    }
}
