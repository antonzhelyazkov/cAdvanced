using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handsOfCards
{
    class handsOfCards
    {
        static void Main(string[] args)
        {
            var players = new Dictionary<string, List<string>>();
            var inputLine = Console.ReadLine();

            while (!inputLine.Equals("JOKER"))
            {
                var inputParams = inputLine.Split(':');
                var cards = inputParams[1].Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                if (!players.ContainsKey(inputParams[0]))
                {
                    players[inputParams[0]] = cards;
                }
                else
                {
                    foreach (var item in cards)
                    {
                        players[inputParams[0]].Add(item);
                    }
                }
                inputLine = Console.ReadLine();
            }

            foreach (var item in players)
            {
                int sum = 0;
                foreach (var couple in item.Value.Distinct())
                {
                    sum += countPoints(couple);
                }
                Console.WriteLine($"{item.Key}: {sum}");
            }
        }

        static int countPoints(string couple)
        {
            Dictionary<string, int> cardPower = new Dictionary<string, int>();
            Dictionary<string, int> cardTypePower = new Dictionary<string, int>();

            cardPower["2"] = 2;
            cardPower["3"] = 3;
            cardPower["4"] = 4;
            cardPower["5"] = 5;
            cardPower["6"] = 6;
            cardPower["7"] = 7;
            cardPower["8"] = 8;
            cardPower["9"] = 9;
            cardPower["10"] = 10;
            cardPower["J"] = 11;
            cardPower["Q"] = 12;
            cardPower["K"] = 13;
            cardPower["A"] = 14;

            cardTypePower["S"] = 4;
            cardTypePower["H"] = 3;
            cardTypePower["D"] = 2;
            cardTypePower["C"] = 1;

            if (couple.Count() == 2)
            {
                return cardPower[couple[0].ToString()] * cardTypePower[couple[1].ToString()];  
            }
            else
            {
                return 10 * cardTypePower[couple[2].ToString()];
            }
        }
    }
}
