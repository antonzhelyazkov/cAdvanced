using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minerTask
{
    class minerTask
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();
            var tempData = new List<string>();
            var store = new Dictionary<string, long>();

            while (!inputLine.Equals("stop"))
            {
                tempData.Add(inputLine);
                inputLine = Console.ReadLine();
            }

            for (int i = 0; i < tempData.Count; i+=2)
            {
                if (!store.ContainsKey(tempData[i]))
                {
                    store.Add(tempData[i], int.Parse(tempData[i + 1]));
                }
                else
                {
                    store[tempData[i]] += int.Parse(tempData[i + 1]);
                }
            }

            foreach (var item in store)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
