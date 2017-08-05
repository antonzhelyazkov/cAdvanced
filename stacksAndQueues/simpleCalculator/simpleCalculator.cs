using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleCalculator
{
    class simpleCalculator
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var reminder = input.Split().Reverse();
            var calculation = new Stack<string>(reminder);

            while (calculation.Count > 1)
            {
                int firstNumber = int.Parse(calculation.Pop());
                var operation = calculation.Pop();
                int secondNumber = int.Parse(calculation.Pop());

                if (operation.Equals("-"))
                {
                    //Console.WriteLine("-");
                    //Console.WriteLine(firstNumber - secondNumber);
                    calculation.Push((firstNumber - secondNumber).ToString());
                }
                else
                {
                    //Console.WriteLine("+");
                    //Console.WriteLine(firstNumber + secondNumber);
                    calculation.Push((firstNumber + secondNumber).ToString());
                }
            }

            Console.WriteLine(calculation.Pop());
        }
    }
}
