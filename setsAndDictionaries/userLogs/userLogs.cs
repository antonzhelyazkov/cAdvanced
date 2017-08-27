using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userLogs
{
    class userLogs
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();
            var userMessages = new SortedDictionary<string, Dictionary<string, int>>();
            while (!inputLine.Equals("end"))
            {
                var inputParams = inputLine.Split(' ');

                var username = inputParams[2].Replace("user=", "");
                var ipAddress = inputParams[0].Replace("IP=", "");
                var ipMessages = new Dictionary<string, int>();

                if (userMessages.ContainsKey(username))
                {
                    if (userMessages[username].ContainsKey(ipAddress))
                    {
                        userMessages[username][ipAddress] += 1;
                    }
                    else
                    {
                        userMessages[username][ipAddress] = 1;
                    }
                }
                else
                {
                    ipMessages[ipAddress] = 1;
                    userMessages[username] = (ipMessages);
                }

                inputLine = Console.ReadLine();
            }

            foreach (var username in userMessages)
            {
                int counter = 1;
                Console.WriteLine($"{username.Key}:");
                foreach (var ip in username.Value)
                {
                    Console.Write($"{ip.Key} => {ip.Value}");
                    if (counter < username.Value.Count)
                    {
                        Console.Write(", ");
                    }
                    else
                    {
                        Console.WriteLine(".");
                    }
                    counter++;
                }
            }
        }
    }
}
