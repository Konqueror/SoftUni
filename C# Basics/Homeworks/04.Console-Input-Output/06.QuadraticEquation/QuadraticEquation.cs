using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());

            double x = b * b - 4 * a * c;

            if (x > 0)
            {
                double SqrtX = Math.Sqrt(x);
                double x1 = (-b - SqrtX) / (2 * a);
                double x2 = (-b + SqrtX) / (2 * a);
                Console.WriteLine("x1: {0}", x1);
                Console.WriteLine("x2: {0}", x2);
            } else if (x == 0)
                {
                    double x12 = -b / 2 * a;
                    Console.WriteLine("Double root, x1/2: {0}", x12);
                } else if (x < 0)
                    {
                        Console.WriteLine("There are no real roots");
                    }
        }
    }
}
