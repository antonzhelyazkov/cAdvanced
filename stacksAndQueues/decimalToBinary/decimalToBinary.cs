using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decimalToBinary
{
    class decimalToBinary
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var binary = new Stack<int>();

            if (input == 0)
            {
                Console.WriteLine(0);
            }

            while (input != 0)
            {
                binary.Push(input % 2);
              //  Console.WriteLine(input % 2);
                input /= 2;
                //Console.WriteLine(input);
            }

           // Console.WriteLine("=========================");

            foreach (var item in binary)
            {
                Console.Write(item);
            }
        }
    }
}
