using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter decimal number: ");
            long n = long.Parse(Console.ReadLine());

            string[] binaryNumber = new string[64];

            for (int i = 0; i < 64; i++)
            {
                long remainder = n % 2;
                string remainderString = remainder.ToString();
                binaryNumber[i] = remainderString;
                n = n / 2;
                if (n == 0)
                {
                    goto BREAK;
                }
            }
        BREAK:
            Array.Reverse(binaryNumber);
            for (int j = 0; j < binaryNumber.Length; j++)
            {
                Console.Write(binaryNumber[j]);
            }
            Console.WriteLine();
        }
    }
}
