using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.RandomizeNumbers
{
    class RandomizeNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Emter integer n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("All numbers between 1 and n in random order:");

            foreach (int i in UniqueRandom(1, n))
            {
                Console.WriteLine(i);
            }
        }

        private static System.Collections.Generic.IEnumerable<int> UniqueRandom(int minInclusive, int maxInclusive)
        {
            List<int> candidates = new List<int>();
            for (int i = minInclusive; i <= maxInclusive; i++)
            {
                candidates.Add(i);
            }
            Random rnd = new Random();
            while (candidates.Count > 0)
            {
                int index = rnd.Next(candidates.Count);
                yield return candidates[index];
                candidates.RemoveAt(index);
            }
        }
    }
}
