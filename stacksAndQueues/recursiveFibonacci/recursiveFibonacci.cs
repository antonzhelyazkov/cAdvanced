using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursiveFibonacci
{
    class recursiveFibonacci
    {
        private static long[] fibNumbers;
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            fibNumbers = new long[number];
            var result = getFibonacci(number);
            Console.WriteLine(result);
        }
        private static long getFibonacci(int nu)
        {
            if (nu < 3)
            {
                return 1;
            }
            if (fibNumbers[nu - 1] != 0)
            {
                return fibNumbers[nu - 1];
            }
            return fibNumbers[nu -1] = getFibonacci(nu - 1) + getFibonacci(nu - 2);
        }
    }
}
