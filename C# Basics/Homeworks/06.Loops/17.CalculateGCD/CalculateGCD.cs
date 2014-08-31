using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.CalculateGCD
{
    class CalculateGCD
    {
        static void Main(string[] args)
        {
            Console.Title = "Greatest Common Divisor (GCD) - Euclidean algorithm ";

            string divA = string.Empty;
            Console.Write("Please enter first number A= ");
            divA = Console.ReadLine();
            int divIntA = 1;

            while (int.TryParse(divA, out divIntA) == false)
            {
                Console.Write("Please enter correct number A= ");
                divA = Console.ReadLine();
            }

            string divB = string.Empty;
            Console.Write("Please enter second number B= ");
            divB = Console.ReadLine();
            int divIntB = 0;

            while (int.TryParse(divB, out divIntB) == false)
            {
                Console.Write("Please enter correct second number B= ");
                divB = Console.ReadLine();
            }

            while (divIntA != divIntB)
            {
                if (divIntA > divIntB)
                {
                    divIntA = divIntA - divIntB;
                }
                else
                {
                    divIntB = divIntB - divIntA;
                }
            }
            Console.WriteLine("GCD is " + divIntA);
        }
    }
}
