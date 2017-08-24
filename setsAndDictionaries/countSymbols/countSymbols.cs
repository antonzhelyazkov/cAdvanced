using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace countSymbols
{
    class countSymbols
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var countDict = new SortedDictionary<char, int>();

            foreach (var item in input)
            {
                if (!countDict.ContainsKey(item))
                {
                    countDict.Add(item, 1);
                }
                else
                {
                    countDict[item]++;
                }
            }

            foreach (var pair in countDict)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value} time/s");
            }
        }
    }
}
