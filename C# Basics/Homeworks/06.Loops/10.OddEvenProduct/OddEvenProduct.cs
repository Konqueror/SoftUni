using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.OddEvenProduct
{
    class OddEvenProduct
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter the integers, seperated sy a space: ");

            string integersPrimal = Console.ReadLine();
            string[] integers = integersPrimal.Split(' ');
            int[] numbersInInt = new Int32[integers.Length];

            for (int i = 0; i < integers.Length; i++)
            {
                numbersInInt[i] = int.Parse(integers[i]);
            }

            int productEven = 1;
            int productOdd = 1;

            for (int i = 0; i < numbersInInt.Length; i = i + 2)
            {
                productOdd *= numbersInInt[i];
            }

            for (int i = 1; i < numbersInInt.Length; i = i + 2)
            {
                productEven *= numbersInInt[i];
            }

            if (productOdd == productEven)
            {
                Console.WriteLine("yes");
                Console.WriteLine("product = {0}", productOdd);
            }
            else
            {
                Console.WriteLine("no");
                Console.WriteLine("odd_product = {0}", productOdd);
                Console.WriteLine("even_product = {0}", productEven);
            }

        }
    }
}
