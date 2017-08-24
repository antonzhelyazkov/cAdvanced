using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace countSameValues
{
    class countSameValues
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var inputTokens = input.Split(' ');

            var dict = new SortedDictionary<double, int>();

            foreach (var token in inputTokens)
            {
                double reminter;
                if (token.Contains(','))
                {
                    reminter = double.Parse(token.Replace(",", "."));
                }
                else
                {
                    reminter = double.Parse(token);
                }
                if (!dict.ContainsKey(reminter))
                {
                    dict.Add(reminter, 1);
                }
                else
                {
                    dict[reminter]++;
                }
            }

            foreach (var pair in dict)
            {
                Console.WriteLine($"{pair.Key} - {pair.Value} times");
            }
        }
    }
}
