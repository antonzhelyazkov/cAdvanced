using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dragonArmy
{
    class dragonArmy
    {
        static void Main(string[] args)
        {
            int numberOfDragons = int.Parse(Console.ReadLine());
            var dragonArmy = new SortedDictionary<string, SortedDictionary<string, HashSet<int>>>();

            for (int i = 0; i < numberOfDragons; i++)
            {
                var inputLine = Console.ReadLine().Split().ToArray();
                var type = inputLine[0];
                var name = inputLine[1];
                var damage = inputLine[2];
                var health = inputLine[3];
                var armor = inputLine[4];
                int intDamage;
                int intHealth;
                int intArmor;

                if (damage.Equals("null"))
                {
                    intDamage = 45;
                }
                else
                {
                    intDamage = int.Parse(damage);
                }

                if (health.Equals("null"))
                {
                    intHealth = 250;
                }
                else
                {
                    intHealth = int.Parse(health);
                }

                if (armor.Equals("null"))
                {
                    intArmor = 10;
                }
                else
                {
                    intArmor = int.Parse(armor);
                }

                var dragonProperites = new HashSet<int>();
                dragonProperites.Add(intDamage);
                dragonProperites.Add(intHealth);
                dragonProperites.Add(intArmor);

                if (dragonArmy.ContainsKey(type))
                {
                    if (dragonArmy[type].ContainsKey(name))
                    {
                        dragonArmy[type][name] = dragonProperites;
                    }
                    else
                    {
                        dragonArmy[type].Add(name, dragonProperites);
                    }
                }
                else
                {
                    var tmpDict = new SortedDictionary<string, HashSet<int>>();
                    tmpDict[name] = dragonProperites;
                    dragonArmy[type] = tmpDict;
                }
            }

            foreach (var dragonType in dragonArmy)
            {
                Console.WriteLine($"{dragonType.Key}");
                foreach (var dragonName in dragonType.Value)
                {
                    Console.WriteLine($"-{dragonName.Key} -> damage: {dragonName.Value.ToArray()[0]}, health: {dragonName.Value.ToArray()[1]}, armor: {dragonName.Value.ToArray()[2]}");
                }
            }
        }
    }
}
