using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Car
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // first line
            for (int i =0; i<n; i++)
            {
                Console.Write(".");
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write("*");
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(".");
            }
            Console.WriteLine();

            // (n/2)-1
            int star1 = n;
            int star2 = 2*n+1;

            for (int i = 0; i < (n / 2) - 1;i++)
            {
                // row
                for (int j=0;j<n*3;j++)
                {

                    if (j + 1 == star1 || j + 1 == star2)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }

                }

                star2++;
                star1--;
                Console.WriteLine();
            }

            for (int i = 0; i < (n / 2) + 1;i++ )
            {
                Console.Write("*");
            }

            for (int i = 0; i < (n*3)-(n+2); i++)
            {
                Console.Write(".");
            }


            for (int i = 0; i < (n / 2) + 1; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            //

            star1 = 1;
            star2 = n * 3;

            for (int i = 0; i < (n / 2) - 2; i++)
            {
                // row
                for (int j = 0; j < n * 3; j++)
                {

                    if (j + 1 == star1 || j + 1 == star2)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }

                }
                Console.WriteLine();
            }

            for (int j = 0; j < n * 3; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();


            // tyre

            for (int i = 0; i < (n / 2) - 2;i++ )
            {
                for (int j = 0; j < n / 2; j++)
                {
                    Console.Write(".");
                }

                Console.Write("*");

                for (int j = 0; j < (n / 2)-1; j++)
                {
                    Console.Write(".");
                }

                Console.Write("*");

                //


                for (int j = 0; j < 3 * n - ((2 * n) + 2)-n/2;j++ )
                {
                    Console.Write(".");
                }



                for (int j = 0; j < n / 2; j++)
                {
                    Console.Write(".");
                }

                Console.Write("*");

                for (int j = 0; j < (n / 2) - 1; j++)
                {
                    Console.Write(".");
                }

                Console.Write("*");

                for (int j = 0; j < n / 2; j++)
                {
                    Console.Write(".");
                }

                Console.WriteLine();

            }
           // Console.WriteLine();
            //tyre end




                // end

                for (int i = 0; i < n / 2; i++)
                {
                    Console.Write(".");
                }

            for (int i = 0; i < (n / 2) + 1;i++ )
            {
                Console.Write("*");
            }


            for (int i = 0; i < (n*3)-((2*n)+2); i++)
            {
                Console.Write(".");
            }


            for (int i = 0; i < (n / 2) + 1; i++)
            {
                Console.Write("*");
            }
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(".");
            }


           Console.WriteLine();

        }
    }
}
