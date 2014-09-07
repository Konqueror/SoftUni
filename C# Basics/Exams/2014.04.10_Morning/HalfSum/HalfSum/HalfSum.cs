using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalfSum
{
    class HalfSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] numbers = new double[2*n];
            double sum1 = 0, sum2 = 0;

            for (int i = 0; i < (2*n); i++)
            {
                numbers[i] = double.Parse(Console.ReadLine());

                if (i < n)
                {
                    sum1 += numbers[i];
                } else
                    {
                        sum2 += numbers[i];
                    }
            }


           // Console.WriteLine("sum1=" + sum1);
           // Console.WriteLine("sum2=" + sum2);

            if (sum1 == sum2)
            {
                Console.WriteLine("Yes, sum=" + sum1);
            } else
                {
                    double diff = (sum1 > sum2) ? sum1 - sum2 : sum2 - sum1;
                    Console.WriteLine("No, diff=" + diff);
                }


        }
    }
}
