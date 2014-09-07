using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanNumbers
{
    class HayvanNumbers
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            int diff = int.Parse(Console.ReadLine());
            bool numbersExist = false;

            for (int a=5; a<10; a++)
                for (int b=5;b<10;b++)
                    for (int c=5;c<10;c++)
                        for (int d=5;d<10;d++)
                            for (int e=5;e<10;e++)
                                for (int f=5;f<10;f++)
                                    for (int g=5;g<10;g++)
                                        for (int h=5;h<10;h++)
                                            for (int i=5;i<10;i++)
                                            {
                                                // check for sum
                                                if (a+b+c+d+e+f+g+h+i == sum)
                                                {
                                                    int abc = Convert.ToInt32(a + "" + b + "" + c);
                                                    int def = Convert.ToInt32(d + "" + e + "" + f);
                                                    int ghi = Convert.ToInt32(g + "" + h + "" + i);

                                                    if ( (ghi-def == diff) && (def-abc == diff) )
                                                    {
                                                        Console.WriteLine(abc + "" + def + "" + ghi);
                                                        numbersExist = true;
                                                    }

                                                }
                                            }
            if (!numbersExist)
            {
                Console.WriteLine("No");
            }
        }
    }
}
