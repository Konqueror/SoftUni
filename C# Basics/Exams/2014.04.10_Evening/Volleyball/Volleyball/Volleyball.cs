using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Volleyball
    {
        static void Main(string[] args)
        {
            bool leap = (Console.ReadLine() == "leap") ? true : false;
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            double total = h + ((48 - h) * 0.75) + (p * 0.6666666666666667);

            if (leap)
            {
                total = total * 1.15;
            }

            Console.WriteLine((int)total);
        }
    }
}
