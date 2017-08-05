using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximumElement
{
    class maximumElement
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            var stack = new Stack<int>();

            for (int i = 0; i < lines; i++)
            {
                var queue = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
               // Console.WriteLine(string.Join(" ", queue));

                if (queue[0].Equals("1"))
                {
                    stack.Push(int.Parse(queue[1]));
                }

                if (queue[0].Equals("2"))
                {
                    stack.Pop();
                }

                if (queue[0].Equals("3"))
                {
                    Console.WriteLine(stack.Max());
                }
            }
        }
    }
}
