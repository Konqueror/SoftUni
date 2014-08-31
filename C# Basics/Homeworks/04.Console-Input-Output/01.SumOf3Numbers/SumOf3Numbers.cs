using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOf3Numbers
{
    class SumOf3Numbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integer a: ");
            float a = float.Parse(Console.ReadLine());

            Console.Write("Enter integer b: ");
            float b = float.Parse(Console.ReadLine());

            Console.Write("Enter integer c: ");
            float c = float.Parse(Console.ReadLine());

            Console.WriteLine("a + b + c = {0}", a + b + c);
        }
    }
}
