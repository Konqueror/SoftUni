using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOf5Numbers
{
    class SumOf5Numbers
    {
        static void Main(string[] args)
        {

            double sum = 0;

            for (int i = 1; i < 6; i++)
            {
                Console.Write("Enter number {0} of 5: ", i);
                sum += double.Parse(Console.ReadLine());
            }

            Console.WriteLine("SUM = " + sum);
        }
    }
}
