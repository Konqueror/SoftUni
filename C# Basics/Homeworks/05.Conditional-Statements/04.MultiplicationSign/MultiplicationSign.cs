using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter 3 numbers: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if ((a > 0) && (b > 0) && (c > 0))
            {
                Console.WriteLine("+");
            }
            else if ((a == 0) || (b == 0) || (c == 0))
            {
                Console.WriteLine("0");
            }
            else if (((a < 0) && (b < 0)) || ((a < 0) && (c < 0)) || ((b < 0) && (c < 0)))
            {
                Console.WriteLine("+");
            }
            else
            {
                Console.WriteLine("-");
            }
        }
    }
}
