using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEvenIntegers
{
    class OddOrEvenIntegers
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter a whole number: ");
            int n = int.Parse(Console.ReadLine());

            bool odd = (n & 1) == 1;

            if (odd)
            {
                Console.WriteLine("Number {0} is odd", n);
            }
            else
            {
                Console.WriteLine("Number {0} is even", n);
            }
        }
    }
}
