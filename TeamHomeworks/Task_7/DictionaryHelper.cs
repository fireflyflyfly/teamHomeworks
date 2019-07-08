using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TeamHomeworks.Task_7
{
    public class DictioanryHelper
    {
        public static Dictionary<int, Country> CountriesD = new Dictionary<int, Country>();

        // Creates and fills a dictionary with countries and their info.
        public static void FillDictionary()
        {
            string[] tempCountries = File.ReadAllLines(@"/Users/yegorabramenkov/Documents/VisualStudiFiles/CountriesList2.txt");
            var interimCountries = new List<String>(tempCountries);

            int countryIndex = 1;
            int i = 0;
            interimCountries.ForEach(c =>
            {
                Country country = new Country();
                country.CountryName = interimCountries[i];
                CountriesD.Add(countryIndex, country);
                countryIndex++;
                i++;
            });
        }

        public static void AddNewCountryToDictionary()
        {
            Country country = new Country();
            country.CountryName = "Ukraine";
            int key = CountriesD.Last().Key + 1;
            CountriesD.Add(key, country);
        }

        public static void AddNewCountryToFile()
        {
            File.AppendAllText(@"/Users/yegorabramenkov/Documents/VisualStudiFiles/CountriesList2.txt", "\nUkraine");
        }

        public static void SetTelenorSupported()
        {
            int key1 = CountriesD.FirstOrDefault(x => x.Value.CountryName.Equals("Denmark")).Key;
            int key2 = CountriesD.FirstOrDefault(x => x.Value.CountryName.Equals("Hungary")).Key;
            CountriesD[key1].IsTelenorSupported = Convert.ToBoolean(1);
            CountriesD[key2].IsTelenorSupported = Convert.ToBoolean(1);
        }

        public static void PrintAllNonSupportedCountries()
        {
            foreach(KeyValuePair<int, Country> kvp in CountriesD.Where(x => x.Value.IsTelenorSupported == false))
            {
                Console.WriteLine("{0}, {1}", kvp.Key, kvp.Value.CountryName);
            }
        }

        public static void SaveChangesToFile()
        {

            string path = (@"/Users/yegorabramenkov/Documents/VisualStudiFiles/FinalCountryList.txt");
            if (!File.Exists(path))
            {
                File.Create(path);
                using (StreamWriter file = new StreamWriter("/Users/yegorabramenkov/Documents/VisualStudiFiles/FinalCountryList.txt"))
                    foreach (KeyValuePair<int, Country> kvp in CountriesD)
                    {
                        file.WriteLine("{0}, {1}, {2}", kvp.Key, kvp.Value.CountryName, kvp.Value.IsTelenorSupported);
                    }
            }
            else if (File.Exists(path))
            {
                using (StreamWriter file = new StreamWriter("/Users/yegorabramenkov/Documents/VisualStudiFiles/FinalCountryList.txt"))
                    foreach (KeyValuePair<int, Country> kvp in CountriesD)
                    {
                        file.WriteLine("{0}, {1}, {2}", kvp.Key, kvp.Value.CountryName, kvp.Value.IsTelenorSupported);
                    }
            }
        }
    }
}
