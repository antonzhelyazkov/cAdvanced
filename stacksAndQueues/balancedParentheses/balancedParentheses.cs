using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balancedParentheses
{
    class balancedParentheses
    {
        static void Main(string[] args)
        {
            var balancedParentheses = Console.ReadLine();
            var openParentheses = new Stack<char>();

            int countNo = 0;
            int countYes = 0;

            foreach (var item in balancedParentheses)
            {
               // Console.WriteLine(item);
                if (item.Equals('(') || item.Equals('[') || item.Equals('{'))
                {
                    openParentheses.Push(item);
                }
                else if (item.Equals(')') || item.Equals(']') || item.Equals('}'))
                {
                    if (openParentheses.Count() > 0)
                    {
                        var lastChar = openParentheses.Pop();
                        if (lastChar.Equals('(') && item.Equals(')'))
                        {
                            countYes++;
                        }
                        else if (lastChar.Equals('{') && item.Equals('}'))
                        {
                            countYes++;
                        }
                        else if (lastChar.Equals('[') && item.Equals(']'))
                        {
                            countYes++;
                        }
                        else
                        {
                            countNo++;
                        }
                    }
                    else
                    {
                        countNo++;
                    }
                }
            }

            if (countNo > 0)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}
