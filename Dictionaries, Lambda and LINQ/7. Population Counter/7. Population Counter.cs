namespace _7.Population_Counter
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            var countryDictionary = new Dictionary<string, string>();
            var cityDictionary = new Dictionary<string, long>();
            var popByCountry = new Dictionary<string, long>();

            bool end = false;

            do
            {
                var inputLine = Console.ReadLine().Split('|');
                if (inputLine[0] == "report")
                {
                    break;
                }

                if (!countryDictionary.ContainsValue(inputLine[1]))
                {
                    countryDictionary.Add(inputLine[0], inputLine[1]);
                    cityDictionary.Add(inputLine[0], long.Parse(inputLine[2]));
                    popByCountry.Add(inputLine[1], long.Parse(inputLine[2]));
                }
                else
                {
                    popByCountry[inputLine[1]] += long.Parse(inputLine[2]);
                    if (!cityDictionary.ContainsKey(inputLine[0]))
                    {
                        countryDictionary.Add(inputLine[0], inputLine[1]);
                        cityDictionary.Add(inputLine[0], long.Parse(inputLine[2]));
                    }
                }
            } while (!end);

            foreach (var country in popByCountry.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value})");
                foreach (var city in cityDictionary.OrderByDescending(x => x.Value))
                {
                    foreach (var item in countryDictionary)
                    {
                        if (item.Key == city.Key && item.Value == country.Key)
                        {
                            Console.WriteLine($"=>{city.Key}: {city.Value}");
                        }
                    }

                }
            }
        }
    }
}
