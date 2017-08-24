using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phonebook
{
    class phonebook
    {
        static void Main(string[] args)
        {
            var phoneBook = new Dictionary<string, string>();
            var search = new HashSet<string>();

            var inputLine = Console.ReadLine();

            while (!inputLine.Equals("search"))
            {
                var inputParams = inputLine.Split('-');
                if (!phoneBook.ContainsKey(inputParams[0]))
                {
                    phoneBook.Add(inputParams[0], inputParams[1]);
                }
                else
                {
                    phoneBook[inputParams[0]] = inputParams[1];
                }
                inputLine = Console.ReadLine();
            }

            var searchNames = Console.ReadLine();

            while (!searchNames.Equals("stop"))
            {
                search.Add(searchNames);
                searchNames = Console.ReadLine();
            }

            foreach (var name in search)
            {
                if (phoneBook.Keys.Contains(name))
                {
                    Console.WriteLine($"{name} -> {phoneBook[name]}");
                }
                else
                {
                    Console.WriteLine($"Contact {name} does not exist.");
                }
            }
        }
    }
}
