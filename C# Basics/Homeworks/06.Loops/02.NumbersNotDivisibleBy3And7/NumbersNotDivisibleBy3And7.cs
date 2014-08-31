using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.NumbersNotDivisibleBy3And7
{
    class NumbersNotDivisibleBy3And7
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter n: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                bool div3 = (i % 3 != 0);
                bool div7 = (i % 7 != 0);
                if (div3 && div7)
                {
                    Console.Write("{0} ", i);
                }
            }
        }
    }
}
