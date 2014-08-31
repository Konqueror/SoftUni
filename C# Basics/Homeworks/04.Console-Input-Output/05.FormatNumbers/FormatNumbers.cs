using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatNumbers
{
    class FormatNumbers
    {
        static void Main(string[] args)
        {
            int a;
            bool checkA;

            do
            {
                Console.Write("Please, enter integers a (0 <= a <= 500): ");
                string aPrimal = Console.ReadLine();
                int.TryParse(aPrimal, out a);
                checkA = (0 <= a) && (a <= 500);
            } while (!checkA);

            float b;
            float c;
            bool checkBC;

            do
            {
                Console.Write("Please, enter floating-point b and a floating-point c, seperated by space: ");
                string floatsPrimal = Console.ReadLine();
                string[] floats = floatsPrimal.Split(' ');
                float.TryParse(floats[0], out b);
                float.TryParse(floats[1], out c);
                checkBC = (b is float) && (c is float);
            } while (!checkBC);

            var stringA = Convert.ToString(a, 2).PadLeft(10, '0');
            Console.WriteLine("|{0,-10:X}|{3,10}|{1,10:0.00}|{2,-10:0.000}|", a, b, c, stringA);
        }
    }
}
