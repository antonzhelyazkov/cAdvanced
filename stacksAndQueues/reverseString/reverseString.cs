using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseString
{
    class reverseString
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var inputStack = new Stack<char>();

            foreach (var item in input)
            {
                inputStack.Push(item);
            }

            foreach (var item in inputStack)
            {
                Console.Write(item);
            }

        }
    }
}
