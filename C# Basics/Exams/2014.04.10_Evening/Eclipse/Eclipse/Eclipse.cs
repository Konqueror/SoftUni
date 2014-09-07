using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eclipse
{
    class Eclipse
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // top frame
            Console.Write(" ");
            for (int i = 0; i < (2 * n - 2); i++)
            {
                Console.Write("*");
            }

            for (int i = 0; i < (n+1); i++)
            {
                Console.Write(" ");
            } 

            for (int i = 0; i < (2 * n - 2); i++)
            {
                Console.Write("*");
            }
            Console.Write(" ");
            // top frame end
            Console.WriteLine();

            for (int j = 0; j < n - 2; j++)
            {
                // glasses
                string row = "*";
                string bridge = "";

                for (int i = 0; i < 2 * n - 2; i++)
                {
                    row += "/";
                }

                row += "*";

                if (j == ((n-2)/2))
                {

                
                    for (int i = 0; i < n - 1; i++ )
                    {
                        bridge += "-";
                    }

                }
                else
                {
                    for (int i = 0; i < n - 1; i++)
                    {
                        bridge += " ";
                    }
                }

                    Console.WriteLine(row+bridge+row);
            }



            // bottom frame
            Console.Write(" ");
            for (int i = 0; i < (2 * n - 2); i++)
            {
                Console.Write("*");
            }

            for (int i = 0; i < (n + 1); i++)
            {
                Console.Write(" ");
            }

            for (int i = 0; i < (2 * n - 2); i++)
            {
                Console.Write("*");
            }
            Console.Write(" ");
            // bottom frame end

            Console.WriteLine();
        }
    }
}
