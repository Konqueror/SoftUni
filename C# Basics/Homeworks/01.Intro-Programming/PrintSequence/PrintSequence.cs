using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintSequence
{
    class PrintSequence
    {
        static void Main(string[] args)
        {
            // very dumb way to do it
            // Console.WriteLine("2 -3 4 -5 6 -7 8 -9 10 -11");

            // more sophisticated way ;-)
            int n = 1;

            for (int i = 2, j = 1; i < 12; i++)
            {
                Console.Write(i * n + " ");
                n *= -1;
            }

            Console.WriteLine("");
        }
    }
}
