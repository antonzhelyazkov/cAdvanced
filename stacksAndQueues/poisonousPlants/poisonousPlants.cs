using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poisonousPlants
{
    class poisonousPlants
    {
        static void Main(string[] args)
        {
            int plants = int.Parse(Console.ReadLine());
            string[] gmo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var alivePlants = new Stack<int>();
            var gmoPlants = new Stack<int>();

            alivePlants.Push(int.Parse(gmo[0]));

            for (int i = 1; i < plants; i++)
            {
                int leftPlant = int.Parse(gmo[i-1]);
                int currentPlant = int.Parse(gmo[i]);
                if (leftPlant < currentPlant)
                {
                    gmoPlants.Push(currentPlant);
                }
                else
                {
                    alivePlants.Push(currentPlant);
                }
            }

            if (gmoPlants.Count() == 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine($"gmo {string.Join(" ", gmoPlants)}");
                Console.WriteLine(string.Join(" ", alivePlants));
                while (gmoPlants.Count() > 0)
                {
                    gmoPlants.Clear();
                    Console.WriteLine($"gmo {string.Join(" ", gmoPlants)}");
                    var tempAlive = new Stack<int>();
                    alivePlants.Reverse();
                    int leftPlant = alivePlants.Pop();
                    Console.WriteLine($"{leftPlant} {alivePlants.Count()}");
                    for (int i = 0; i < alivePlants.Count(); i++)
                    {
                        Console.WriteLine($"count {i}");
                        Console.WriteLine(alivePlants.Pop());
                    }
                    alivePlants = tempAlive;
                   // Console.WriteLine(string.Join(" ", alivePlants));
                }
            }

            }
    }
}
