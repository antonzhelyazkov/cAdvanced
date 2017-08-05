using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicStackOperations
{
    class basicStackOperations
    {
        static void Main(string[] args)
        {
            var variables = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var inputLine = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();



            int n = int.Parse(variables[0]);
            int s = int.Parse(variables[1]);
            int x = int.Parse(variables[2]);

            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
               // Console.WriteLine(inputLine[i]);
                numbers.Push(int.Parse(inputLine[i]));
            }

           for (int i = 0; i < s; i++)
           {
               numbers.Pop();
           }

            if (numbers.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (numbers.Count > 0 )
            {
                Console.WriteLine(numbers.ToArray().Min());
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}