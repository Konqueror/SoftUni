using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestNumber
{
    class BiggestNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter 3 numbers: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int biggestNumber = a;

            if ((b > a) && (b > c))
            {
                biggestNumber = b;
            }
            if ((c > a) && (c > b))
            {
                biggestNumber = c;
            }

            Console.WriteLine("The biggest number is {0}.", biggestNumber);
        }
    }
}
