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
            string[] lines = File.ReadAllLines(@"/Users/yegorabramenkov/Documents/VisualStudiFiles/CountriesList2.txt");
            int i = 1;

            foreach (string country in lines)
            {
                CountriesDic.Add(i, country);
                i++;
            }

            foreach (KeyValuePair<int, string> kvp in CountriesDic)
            {
                Console.WriteLine("{0}: {1}", kvp.Key, kvp.Value);
            }

        }
    }
}
