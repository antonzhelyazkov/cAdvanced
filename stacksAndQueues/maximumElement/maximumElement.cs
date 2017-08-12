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
            var maxElement = new Stack<int>();

            var stack = new Stack<int>();

            for (int i = 0; i < lines; i++)
            {
                var queue = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
               // Console.WriteLine(string.Join(" ", queue));

                if (queue[0].Equals("1"))
                {
                    int currentElemet = (int.Parse(queue[1]));
                    if (maxElement.Count() == 0)
                    {
                        maxElement.Push(currentElemet);
                    }
                    else if (maxElement.Peek() < currentElemet)
                    {
                        maxElement.Push(currentElemet);
                    }
                    stack.Push(currentElemet);
                }

                if (queue[0].Equals("2"))
                {
                    int poppedElement = stack.Pop();
                    if (maxElement.Peek() == poppedElement)
                    {
                        maxElement.Pop();
                    }
                }

                if (queue[0].Equals("3"))
                {
                    Console.WriteLine(maxElement.Peek());
                }
            }
        }
    }
}
