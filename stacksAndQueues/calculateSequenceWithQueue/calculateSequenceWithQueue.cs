using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculateSequenceWithQueue
{
    class calculateSequenceWithQueue
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());

            var magicSequence = new Queue<long>();
            List<long> seqNumbers = new List<long>();
            seqNumbers.Add(n);

            magicSequence.Enqueue(n);
            while (seqNumbers.Count < 51)
            {
                var firstItem = magicSequence.Peek() + 1;
                magicSequence.Enqueue(firstItem);
                var secondItem = (magicSequence.Peek() * 2) + 1;
                magicSequence.Enqueue(secondItem);
                var thirdItem = firstItem + 1;
                magicSequence.Enqueue(thirdItem);

                seqNumbers.Add(firstItem);
                seqNumbers.Add(secondItem);
                seqNumbers.Add(thirdItem);

                magicSequence.Dequeue();

            }

            Console.WriteLine(string.Join(" ", seqNumbers.Take(50)));
        }
    }
}
