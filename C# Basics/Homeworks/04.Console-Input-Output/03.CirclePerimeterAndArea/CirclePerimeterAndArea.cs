using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclePerimeterAndArea
{
    class CirclePerimeterAndArea
    {
        static void Main(string[] args)
        {
            Console.Write("r = ");
            double r = double.Parse(Console.ReadLine());

            double area = 2 * Math.PI * r;
            double perimeter = Math.PI * r * r;

            Console.WriteLine("Perimeter = {0}",  area.ToString("#.00"));
            Console.WriteLine("Area = {0}", perimeter.ToString("#.00"));
        }
    }
}
