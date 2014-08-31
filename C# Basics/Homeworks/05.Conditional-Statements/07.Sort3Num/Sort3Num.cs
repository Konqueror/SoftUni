using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort3Num
{
    class Sort3Num
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre 3 real numbers: ");
            float num1 = float.Parse(Console.ReadLine());
            float num2 = float.Parse(Console.ReadLine());
            float num3 = float.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                if (num2 > num3)
                {
                    Console.WriteLine("{0} {1} {2}", num1, num2, num3);
                }
                else
                {
                    if (num1 > num3)
                    {
                        Console.WriteLine("{0} {1} {2}", num1, num3, num2);
                    }
                    else
                    {
                        Console.WriteLine("{0} {1} {2}", num3, num1, num2);
                    }
                }
            }
            else
            {
                if (num1 > num3)
                {
                    Console.WriteLine("{0} {1} {2}", num2, num1, num3);
                }
                else
                {
                    if (num2 > num3)
                    {
                        Console.WriteLine("{0} {1} {2}", num2, num3, num1);
                    }
                    else
                    {
                        Console.WriteLine("{0} {1} {2}", num3, num2, num1);
                    }
                }
            }
        }
    }
}
