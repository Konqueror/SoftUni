using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.RandomNumbers
{
    class RandomNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter 3 integers - n, min and max (min ≤ max): ");
            int n = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());

            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                int randomInt = random.Next(min, max);
                Console.WriteLine(randomInt);
            }
        }
    }
}
