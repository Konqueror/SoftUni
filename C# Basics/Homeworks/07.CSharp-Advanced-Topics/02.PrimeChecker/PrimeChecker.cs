using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02.PrimeChecker
{
    class PrimeChecker
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            IsPrime(n);
        }

        private static void IsPrime(BigInteger n)
        {
            if (n == 0)
            {
                Console.WriteLine("false");
            }
            else if (n != 1)
            {
                BigInteger numberDividers = 0;
                for (BigInteger i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0)
                    {
                        numberDividers = numberDividers + 1;
                        break;
                    }
                    else
                    {
                        numberDividers = numberDividers + 0;
                    }
                }
                if (numberDividers == 0)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
