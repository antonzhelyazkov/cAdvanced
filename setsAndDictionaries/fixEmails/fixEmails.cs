using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fixEmails
{
    class fixEmails
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();
            var tempData = new List<string>();
            var store = new Dictionary<string, string>();

            while (!inputLine.Equals("stop"))
            {
                tempData.Add(inputLine);
                inputLine = Console.ReadLine();
            }

            for (int i = 0; i < tempData.Count; i += 2)
            {
                if (!tempData[i+1].EndsWith(".us") && !tempData[i+1].EndsWith(".uk"))
                {
                    Console.WriteLine($"{tempData[i]} -> {tempData[i + 1]}");
                }
            }

  //          foreach (var item in store)
  //          {
  //              Console.WriteLine($"{item.Key} -> {item.Value}");
  //          }
        }
    }
}
