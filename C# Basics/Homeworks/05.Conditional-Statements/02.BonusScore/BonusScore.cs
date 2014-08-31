using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter integer n, (1 < n < 9): ");
            int n = int.Parse(Console.ReadLine());

            if ((1 <= n) && (n <= 3))
            {
                n *= 10;
                Console.WriteLine("result is {0}", n);
            }
            else if ((4 <= n) && (n <= 6))
            {
                n *= 100;
                Console.WriteLine("result is {0}", n);
            }
            else if ((7 <= n) && (n <= 9))
            {
                n *= 1000;
                Console.WriteLine("result is {0}", n);
            }
            else if ((n == 0) || (n > 9))
            {
                Console.WriteLine("invalid score");
            }

        }
    }
}
