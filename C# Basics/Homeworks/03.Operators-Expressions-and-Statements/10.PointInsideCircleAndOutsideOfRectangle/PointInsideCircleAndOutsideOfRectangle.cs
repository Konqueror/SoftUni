using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInsideCircleAndOutsideOfRectangle
{
    class PointInsideCircleAndOutsideOfRectangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give \"x\" coordinate of the point:");
            double coordX = double.Parse(Console.ReadLine());

            Console.WriteLine("Give \"y\" coordinate of the point:");
            double coordY = double.Parse(Console.ReadLine());

            double centerX = 1;
            double centerY = 1;
            double radius = 1.5;
            double substrX = coordX - centerX;
            double substrY = coordY - centerY;

            bool check = (Math.Pow(substrX, 2) + Math.Pow(substrY, 2)) <= Math.Pow(radius, 2);

            if ((check == true) && (coordY > 1))
            {
                Console.WriteLine("The given point (x, y) is inside the circle and outside of the rectangle.");
            } else
                {
                    Console.WriteLine("The given point (x, y) is NOT where it should be.");
                }
        }
    }
}
