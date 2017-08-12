using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackFibonacci
{
    class stackFibonacci
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var fibonacci = new Stack<long>();
            fibonacci.Push(0);
            fibonacci.Push(1);

            for (int i = 0; i < number - 1; i++)
            {
                //Console.WriteLine(i);
                long elementMinusOne = fibonacci.Pop();
                long elementMinusTwo = fibonacci.Pop();
              //  Console.WriteLine($"one {elementMinusOne}");
              //  Console.WriteLine($"two {elementMinusTwo}");
                long lastElement = elementMinusOne + elementMinusTwo;

                fibonacci.Push(elementMinusTwo);
                fibonacci.Push(elementMinusOne);
                fibonacci.Push(lastElement);
             //   Console.WriteLine($"current count {fibonacci.Count()}");
             //   int[] temp = fibonacci.ToArray();
             //   Console.WriteLine(string.Join(" ", fibonacci));
            }

            //Console.WriteLine($"count {fibonacci.Count()}");
            Console.WriteLine(fibonacci.Peek());
        }
    }
}
