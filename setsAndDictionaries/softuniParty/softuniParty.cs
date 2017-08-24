using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace softuniParty
{
    class softuniParty
    {
        static void Main(string[] args)
        {
            var reservations = new SortedSet<string>();
            var input = Console.ReadLine();

            while (!input.Equals("PARTY"))
            {
                reservations.Add(input);
                input = Console.ReadLine();
            }

            while (!input.Equals("END"))
            {
                reservations.Remove(input);
                input = Console.ReadLine();
            }

            Console.WriteLine(reservations.Count());
            foreach (var item in reservations)
            {
                Console.WriteLine(item);
            }
        }
    }
}
