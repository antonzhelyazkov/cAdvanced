using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace populationCounter
{
    class populationCounter
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();
            var countries = new Dictionary<string, Dictionary<string, long>>();
            var countryPopulation = new Dictionary<string, long>();

            while (!inputLine.Equals("report"))
            {
                var inputParams = inputLine.Split('|');
                var city = inputParams[0];
                var country = inputParams[1];
                long population = long.Parse(inputParams[2]);
                var cityPopulation = new Dictionary<string, long>();

                if (countries.ContainsKey(country))
                {
                    countries[country][city] = population;
                    countryPopulation[country] += population;
                }
                else
                {
                    cityPopulation[city] = population;
                    countries[country] = cityPopulation;
                    countryPopulation[country] = population;
                }
                inputLine = Console.ReadLine();
            }

            foreach (var country in countryPopulation.OrderByDescending(r => r.Value))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value})");
                foreach (var item in countries)
                {
                    if (item.Key.Equals(country.Key))
                    {
                        foreach (var city in item.Value.OrderByDescending(r => r.Value))
                        {
                            Console.WriteLine($"=>{city.Key}: {city.Value}");
                        }
                    }
                }
            }
        }
    }
}
