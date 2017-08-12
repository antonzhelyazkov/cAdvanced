using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace truckTour
{
    class truckTour
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            var pumps = new Queue<long>();

            for (long i = 0; i < n; i++)
            {
                var line = Console.ReadLine();
                string[] splitLine = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                pumps.Enqueue(long.Parse(splitLine[0]));
                pumps.Enqueue(long.Parse(splitLine[1]));
            }

            //Console.WriteLine(string.Join(" ", pumps));

            for (long i = 0; i < n; i++)
            {
                //Console.WriteLine(i);
                //var currentQueue = new Queue<int>();
                //currentQueue = pumps;
                if (isSolution(pumps))
                {
                    Console.WriteLine(i);
                    break;
                }

                if (pumps.Count() > 0)
                {
                    long firstElement = pumps.Dequeue();
                    long secondElement = pumps.Dequeue();

                    pumps.Enqueue(firstElement);
                    pumps.Enqueue(secondElement);
                }
            }
        }


        private static bool isSolution(Queue<long> test)
        {
            //Console.WriteLine(string.Join(" ", test));
            long yes = 0;
            long no = 0;
            long trunk = 0;
            for (int i = 0; i < test.Count()/2; i++)
            {
                //Console.WriteLine(test.Count());
                long litters = test.Dequeue();
                long distance = test.Dequeue();
                trunk = trunk + litters - distance;
                if (trunk >= 0)
                {
                    //Console.WriteLine("yes");
                    yes++;
                }
                else
                {
                   // Console.WriteLine("no");
                    no++;
                }
                test.Enqueue(litters);
                test.Enqueue(distance);
            }

            if (no > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
