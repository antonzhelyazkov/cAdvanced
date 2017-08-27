using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logsAgregator
{
    class logsAgregator
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var userIP = new SortedDictionary<string, SortedSet<string>>();
            var userSessions = new SortedDictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine().Split(' ');
                var userName = inputLine[1];
                var ip = inputLine[0];
                int sessions = int.Parse(inputLine[2]);

                if (userIP.ContainsKey(userName))
                {
                    userIP[userName].Add(ip);
                    userSessions[userName] += sessions;
                }
                else
                {
                    var temIP = new SortedSet<string>();
                    temIP.Add(ip);
                    userIP[userName] = temIP;
                    userSessions[userName] = sessions;
                }
            }

            foreach (var user in userSessions)
            {
                foreach (var item in userIP)
                {
                    if (user.Key.Equals(item.Key))
                    {
                        Console.WriteLine($"{item.Key}: {user.Value} [{string.Join(", ", item.Value)}]");
                    }
                }
            }
        }
    }
}
