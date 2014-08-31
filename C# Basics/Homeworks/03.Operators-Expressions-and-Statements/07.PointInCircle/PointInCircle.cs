using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInCircle
{
    class PointInCircle
    {
        static void Main(string[] args)
        {
            int r = 2;

            Console.Write("x: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("y: ");
            int y = int.Parse(Console.ReadLine());

            bool isInCircle = Math.Pow(x, 2) + Math.Pow(y, 2) < Math.Pow(r, 2);

            if (isInCircle)
            {
                Console.WriteLine("The point IS in the circle");
            }
            else
            {
                Console.WriteLine("The point is NOT in the circle");
            }
        }
    }
}
