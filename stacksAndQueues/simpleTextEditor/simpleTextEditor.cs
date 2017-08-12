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
                    foreach (var item in currentCommand[1])
                    {
                        text += item;
                    }
                    undoOperations.Push(text);
                   // Console.WriteLine(string.Join(" ", text));
                   // Console.WriteLine(undoOperations.Count());
                   // Console.WriteLine(undoOperations.Peek());
                }
                if (currentCommand[0].Equals("2"))
                {
                    Console.WriteLine(text);
                    text = text.Remove(text.Length - int.Parse(currentCommand[1]), int.Parse(currentCommand[1]));
                    Console.WriteLine(text);
                    undoOperations.Push(text);
                    //Console.WriteLine(undoOperations.Count());
                }
                if (currentCommand[0].Equals("3"))
                {
                    Console.WriteLine(text[int.Parse(currentCommand[1]) - 1]);
                }
                if (currentCommand[0].Equals("4"))
                {
                    undoOperations.Pop();
                    text = undoOperations.Peek();
                }
                //Console.WriteLine($"executed command {i}");
            }
            //Console.WriteLine(string.Join(" ", text));
        }
    }
}
