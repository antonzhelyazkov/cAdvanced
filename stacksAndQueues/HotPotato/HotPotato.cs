using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotPotato
{
    class HotPotato
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var queue = new Queue<string>(input.Split(' '));
            int number = int.Parse(Console.ReadLine());
        }
    }
}
