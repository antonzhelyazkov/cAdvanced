using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uniqueUsernames
{
    class uniqueUsernames
    {
        static void Main(string[] args)
        {
            int line = int.Parse(Console.ReadLine());
            var usernames = new HashSet<string>();

            for (int i = 0; i < line; i++)
            {
                var username = Console.ReadLine();
                usernames.Add(username);
            }

            foreach (var item in usernames)
            {
                Console.WriteLine(item);
            }
        }
    }
}
