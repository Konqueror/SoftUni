using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SortNumbers
{
    class SortNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrayNumbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                arrayNumbers[i] = int.Parse(Console.ReadLine());
            }

            int[] sortedNumbers = arrayNumbers.OrderBy(i => i).ToArray();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(sortedNumbers[i]);
            }
        }
    }
}
