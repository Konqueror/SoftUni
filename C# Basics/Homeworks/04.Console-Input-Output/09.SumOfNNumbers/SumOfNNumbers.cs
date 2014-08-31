using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNNumbers
{
    class SumOfNNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0;

            Console.WriteLine("Enter {0} more numbers: ", n);

            while (n-- != 0) sum += double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("SUM = " + sum);
        }
    }
}
