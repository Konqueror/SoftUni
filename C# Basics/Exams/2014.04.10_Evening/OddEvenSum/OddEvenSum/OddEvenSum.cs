using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenSum
{
    class OddEvenSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int tmpNumber = 0;
            int sumOdd = 0;
            int sumEven = 0;

            bool isEven = true;

            for (int i = 0; i<2*n; i++)
            {
                tmpNumber = int.Parse(Console.ReadLine());

                if (isEven)
                {
                    sumEven += tmpNumber;
                    isEven = false;
                }
                else
                {
                    sumOdd += tmpNumber;
                    isEven = true;
                }
            }

            if (sumEven == sumOdd)
            {
                Console.WriteLine("Yes, sum={0}", sumEven);
            }
            else
            {
                int diff = 0;

                if (sumEven > sumOdd)
                {
                    diff = sumEven - sumOdd;
                }
                else
                {
                    diff = sumOdd - sumEven;
                }

                Console.WriteLine("No, diff={0}", diff);
            }


        }
    }
}
