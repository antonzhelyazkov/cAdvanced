using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace periodicTable
{
    class periodicTable
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            var uniqueElements = new SortedSet<string>();

            for (int i = 0; i < lines; i++)
            {
                var elements = Console.ReadLine().Split();
                foreach (var item in elements)
                {
                    uniqueElements.Add(item);
                }
            }

            Console.WriteLine(string.Join(" ", uniqueElements));
        }
    }
}
