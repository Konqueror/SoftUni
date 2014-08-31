using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.TrailingZeroes
{
    class TrailingZeroes
    {
        static void Main(string[] args)
        {
            int n;
            bool check;

            do
            {
                Console.Write("Please, enter integer n: ");
                int.TryParse(Console.ReadLine(), out n);
                check = (n is int);
            } while (!check);

            int k = 0;
            double powOf5 = 5;

            while (powOf5 <= n)
            {
                k++;
                powOf5 = Math.Pow(5, (k + 1));
            }

            double sum = 0;

            for (int i = 1; i <= k; i++)
            {
                double powOf5second = Math.Pow(5, i);
                int powOf5SecondInt = (int)powOf5second;
                sum += (n / powOf5SecondInt);
            }

            Console.WriteLine("The number of the trailing zeroes of n! is {0}.", sum);
        }
    }
}
