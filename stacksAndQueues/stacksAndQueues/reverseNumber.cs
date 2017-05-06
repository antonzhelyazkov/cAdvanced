using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stacksAndQueues
{
    class reverseNumber
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            Stack<int> numbers = new Stack<int>();
            foreach (var item in input)
            {
                numbers.Push(int.Parse(item));
            }

            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
