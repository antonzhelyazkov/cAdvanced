using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace setsOfElemetns
{
    class setsOfElemetns
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var inputTokens = input.Split(' ');

            var nSet = new SortedSet<int>();
            var mSet = new SortedSet<int>();
            var repeatingElements = new SortedSet<int>();

            for (int i = 0; i < int.Parse(inputTokens[0]); i++)
            {
                nSet.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < int.Parse(inputTokens[1]); i++)
            {
                mSet.Add(int.Parse(Console.ReadLine()));
            }

            foreach (var item in nSet)
            {
                if (mSet.Contains(item))
                {
                    repeatingElements.Add(item);
                }
            }

            Console.WriteLine(string.Join(" ", repeatingElements));
        }
    }
}
