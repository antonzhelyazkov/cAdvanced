using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleTextEditor
{
    class simpleTextEditor90
    {
        static void Main(string[] args)
        {
            int commands = int.Parse(Console.ReadLine());
            var undoOperations = new Stack<string>();
            string text = "";

            for (int i = 0; i < commands; i++)
            {
                string[] currentCommand = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (currentCommand[0].Equals("1"))
                {
                    text += currentCommand[1];
                    undoOperations.Push(text);
                   // Console.WriteLine(string.Join(" ", text));
                   // Console.WriteLine(undoOperations.Count());
                   // Console.WriteLine(undoOperations.Peek());
                }
                if (currentCommand[0].Equals("2"))
                {
                    //Console.WriteLine($"before 2 {text}");
                    int removeSymbols = int.Parse(currentCommand[1]);
                    text = text.Substring(0, text.Length - removeSymbols);
                    undoOperations.Push(text);

               //    if (text.Length >= removeSymbols)
               //    {
               //        text = text.Remove(text.Length - removeSymbols, removeSymbols);
               //        //Console.WriteLine($"after 2 {text}");
               //        undoOperations.Push(text);
               //        //Console.WriteLine(undoOperations.Count());
               //    }
                }
                if (currentCommand[0].Equals("3"))
                {
                    int printNumber = int.Parse(currentCommand[1]) - 1;
                    //Console.WriteLine($"{printNumber} {text.Count()}");
                    if (printNumber >= 0 && printNumber < text.Count())
                    {
                        //Console.WriteLine(printNumber);
                        Console.WriteLine(text[printNumber]);
                    }
                }
                if (currentCommand[0].Equals("4"))
                {
                    if (undoOperations.Count() > 0)
                    {
                        undoOperations.Pop();
                        text = undoOperations.Peek();
                    }
                    //Console.WriteLine(text);
                }
                //Console.WriteLine($"executed command {i}");
            }
            //Console.WriteLine(string.Join(" ", text));
        }
    }
}
