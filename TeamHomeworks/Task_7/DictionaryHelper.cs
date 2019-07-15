using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace TeamHomeworks.Task_7
{
    public class DictioanryHelper
    {
        public static Dictionary<int, Country> CountriesD = new Dictionary<int, Country>();

        // Creates and fills a dictionary with countries and their info.
        public static void FillDictionary()
        {
            List<string> interimCountries = File.ReadAllLines(@"/Users/yegorabramenkov/Documents/VisualStudiFiles/CountriesList2.txt")
                .Where(x => !string.IsNullOrEmpty(x)).ToList();        

            int countryIndex = 1;
            Regex reg = new Regex(@"[\w ]+");
            interimCountries.ForEach(countryName =>
            {
                string croppedCountryName = Regex.Replace(reg.Match(countryName).Value.ToLower().Trim(), @"\s{2,}", "");
                CountriesD.Add(countryIndex, new Country(croppedCountryName));
                countryIndex++;
            });
        }

        //sort this one first by key
        public static void AddNewCountryToDictionary()
        {
            CountriesD.OrderBy(k => k.Key);
            Country country = new Country("Ukraine");
            int key = CountriesD.Last().Key + 1;
            CountriesD.Add(key, country);
        }

        public static void AddNewCountryToFile()
        {
            File.AppendAllText(@"/Users/yegorabramenkov/Documents/VisualStudiFiles/CountriesList2.txt", "\nUkraine");
        }


        //get list of telenorsupported countries and then search it for something
        public static void SetTelenorSupported()
        {
            int key1 = CountriesD.First(x => x.Value.CountryName.Equals("denmark")).Key;
            int key2 = CountriesD.First(x => x.Value.CountryName.Equals("hungary")).Key;
            CountriesD[key1].IsTelenorSupported = Convert.ToBoolean(1);
            CountriesD[key2].IsTelenorSupported = Convert.ToBoolean(1);
        }

        public static void PrintAllNonSupportedCountries()
        {
            foreach (var kvp in CountriesD.Where(x => !x.Value.IsTelenorSupported))
            {
                Console.WriteLine($"{kvp.Key}, {kvp.Value.CountryName}, {kvp.Value.IsTelenorSupported}");
            }
        }

        public static void SaveChangesToFile()
        {

            string path = (@"/Users/yegorabramenkov/Documents/VisualStudiFiles/FinalCountryList.txt");
            StreamWriter file = new StreamWriter(path);
            if (!File.Exists(path))
            {
                File.Create(path);  
            }
            
            foreach (var kvp in CountriesD)
            {
                file.WriteLine($"{kvp.Key}, {kvp.Value.CountryName}, {kvp.Value.IsTelenorSupported}");
            }
            file.Close();
        }
    }
}
