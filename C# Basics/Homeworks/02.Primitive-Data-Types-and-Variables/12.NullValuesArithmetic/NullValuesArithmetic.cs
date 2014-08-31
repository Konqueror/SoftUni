using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main(string[] args)
        {
            int? a = null;
            double? b = null;

            Console.WriteLine("a: {0}, b: {1}", a, b);

            a += null;
            b += 123.456;

            Console.WriteLine("a: {0}, b: {1}", a, b);
        }
    }
}
