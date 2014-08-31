using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideBy7And5
{
    class DivideBy7And5
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter a whole number: ");
            int n = int.Parse(Console.ReadLine());

            bool divCheck = (n % 35) == 0;

            if (divCheck)
            {
                Console.WriteLine("TRUE <== Number {0} is divisible by 5 and 7", n);
            }
            else
            {
                Console.WriteLine("FALSE <== Number {0} is NOT divisible by 5 and 7", n);
            }
        }
    }
}
