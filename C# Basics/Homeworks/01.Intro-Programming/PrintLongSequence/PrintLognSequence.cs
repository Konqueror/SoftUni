using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintLongSequence
{
    class PrintLognSequence
    {
        static void Main(string[] args)
        {
            int n = 1;

            for (int i = 2, j = 1; i < 1002; i++)
            {
                Console.Write(i * n + " ");
                n *= -1;
            }

            Console.WriteLine("");
        }
    }
}
