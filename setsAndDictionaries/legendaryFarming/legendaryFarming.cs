using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace legendaryFarming
{
    class legendaryFarming
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine().Split();
            bool notWin = true;
            var winner = new HashSet<string>();
            var keyMaterials = new Dictionary<string, int>();
            var otherMaterials = new SortedDictionary<string, int>();

            keyMaterials["shards"] = 0;
            keyMaterials["fragments"] = 0;
            keyMaterials["motes"] = 0;

            while (notWin)
            {
                for (int i = 0; i < inputLine.Count() - 1; i+=2)
                {
                    var material = inputLine[i + 1].ToLower();
                    int amount = int.Parse(inputLine[i]);

                    if (material.Equals("shards") || material.Equals("fragments") || material.Equals("motes"))
                    {
                        keyMaterials[material] += amount;
                        if (keyMaterials[material] > 249)
                        {
                            notWin = false;
                            winner.Add(material);
                            break;
                        }
                    }
                    else
                    {
                        if (otherMaterials.ContainsKey(material))
                        {
                            otherMaterials[material] += amount;
                        }
                        else
                        {
                            otherMaterials[material] = amount;
                        }
                    }
                }
                if (notWin)
                {
                    inputLine = Console.ReadLine().Split();
                }
            }

            var win = winner.ToArray();

            if (win[0].Equals("shards"))
            {
                Console.WriteLine("Shadowmourne obtained!");
            }
            if (win[0].Equals("fragments"))
            {
                Console.WriteLine("Valanyr obtained!");
            }
            if (win[0].Equals("motes"))
            {
                Console.WriteLine("Dragonwrath obtained!");
            }

            keyMaterials[win[0]] -= 250;

            foreach (var item in keyMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in otherMaterials)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
