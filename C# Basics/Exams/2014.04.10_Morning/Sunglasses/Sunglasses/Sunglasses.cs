using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Sunglasses
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double bridge = (n / 2) -1;

            for (int i = 0; i < 2 * n; i++)
            {
                Console.Write("*");
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(" ");
            }

            for (int i = 0; i < 2 * n; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();


            //
            for (int j = 0; j < n - 2; j++)
            {
                Console.Write("*");

                for (int i = 0; i < (2 * n - 2); i++)
                {
                    Console.Write("/");
                }

                Console.Write("*");

                for (int i = 0; i < n; i++)
                {
                    if (j == bridge)
                    {
                        Console.Write("|");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    
                }

                Console.Write("*");

                for (int i = 0; i < (2 * n - 2); i++)
                {
                    Console.Write("/");
                }

                Console.Write("*");


                Console.WriteLine();
                //
            }

            for (int i = 0; i < 2 * n; i++)
            {
                Console.Write("*");
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(" ");
            }

            for (int i = 0; i < 2 * n; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();

        }
    }
}
