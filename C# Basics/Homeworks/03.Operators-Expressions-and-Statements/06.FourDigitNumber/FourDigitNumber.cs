using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter a four digit integer \"abcd\": ");
            int number = int.Parse(Console.ReadLine());

            var firstDigit = (number / 1) % 10;
            var secondDigit = (number / 10) % 10;
            var thirdDigit = (number / 100) % 10;
            var fourthDigit = (number / 1000) % 10;

            int a = fourthDigit;
            int b = thirdDigit;
            int c = secondDigit;
            int d = firstDigit;

            int sumDigits = (a + b + c + d);

            Console.WriteLine("The sum of the digits is: {0}", sumDigits);
            Console.WriteLine("\"dcba\": {0}{1}{2}{3}", d, c, b, a);
            Console.WriteLine("\"dabc\": {0}{1}{2}{3}", d, a, b, c);
            Console.WriteLine("\"acbd\": {0}{1}{2}{3}", a, c, b, d);
        }
    }
}
