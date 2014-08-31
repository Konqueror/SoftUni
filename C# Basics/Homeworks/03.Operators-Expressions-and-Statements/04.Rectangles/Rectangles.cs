using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangles
{
    class Rectangles
    {
        static void Main(string[] args)
        {
            Console.Write("Height: ");
            decimal height = decimal.Parse(Console.ReadLine());

            Console.Write("Width: ");
            decimal width = decimal.Parse(Console.ReadLine());

            decimal area = height * width;
            decimal perimeter = 2 * height + 2 * width;

            Console.WriteLine("The perimeter is: {0}", perimeter);
            Console.WriteLine("The area is: {0}", area);
        }
    }
}
