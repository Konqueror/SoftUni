using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestNumberOf5
{
    class BiggestNumberOf5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter 5 numbers: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());

            int biggestNumber = a;

            if ((b > a))
            {
                biggestNumber = b;
            }
            if ((c > a) && (c > b))
            {
                biggestNumber = c;
            }
            if ((d > a) && (d > b) && (d > c))
            {
                biggestNumber = d;
            }
            if ((e > a) && (e > b) && (e > c) && (e > d))
            {
                biggestNumber = e;
            }

            Console.WriteLine("The biggest number is {0}.", biggestNumber);
        }
    }
}
