using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace srabskoUnleashed
{
    class srabskoUnleashed
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();
            var mainPlace = new Dictionary<string, Dictionary<string, int>>();

            while (!inputLine.Equals("End"))
            {
                string patternLine = @"(.*)\s{1}@(.*)\s{1}(\d+)\s{1}(\d+)";
                Regex regexPlace = new Regex(patternLine);
                Match matchPlace = regexPlace.Match(inputLine);

                if (regexPlace.IsMatch(inputLine))
                {
                    var place = matchPlace.Groups[2].Value.Trim();
                    int ticketPrice = int.Parse(matchPlace.Groups[3].Value);
                    int visitors = int.Parse(matchPlace.Groups[4].Value);
                    var srabskoStar = matchPlace.Groups[1].Value.Trim();
                    int amount = visitors * ticketPrice;

                    if (mainPlace.ContainsKey(place))
                    {
                        if (mainPlace[place].ContainsKey(srabskoStar))
                        {
                            mainPlace[place][srabskoStar] += amount;
                        }
                        else
                        {
                            mainPlace[place][srabskoStar] = amount;
                        }
                    }
                    else
                    {
                        var tempDict = new Dictionary<string, int>();
                        tempDict[srabskoStar] = amount;
                        mainPlace[place] = tempDict;
                    }

                }

                inputLine = Console.ReadLine();
            }

            foreach (var place in mainPlace)
            {
                Console.WriteLine(place.Key);
                foreach (var star in place.Value.OrderByDescending(r => r.Value))
                {
                    Console.WriteLine($"#  {star.Key} -> {star.Value}");
                }
            }
        }
    }
}
