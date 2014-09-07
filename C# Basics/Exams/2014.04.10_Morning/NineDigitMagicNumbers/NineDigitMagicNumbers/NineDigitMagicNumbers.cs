using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NineDigitMagicNumbers
{
    class NineDigitMagicNumbers
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            int diff = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int a=1; a<8; a++)
                for (int b=1; b<8; b++)
                    for (int c=1; c<8; c++)
                        for (int d=1; d<8; d++)
                            for (int e=1; e<8; e++)
                                for (int f=1; f<8; f++)
                                    for (int g=1; g<8; g++)
                                        for (int h = 1; h < 8; h++)
                                            for (int i = 1; i < 8; i++)
                                            {
                                                if (a+b+c+d+e+f+g+h+i == sum)
                                                {
                                                    //int abc = Convert.ToInt16(a.ToString() + b.ToString() + c.ToString());
                                                    //int def = Convert.ToInt16(d.ToString() + e.ToString() + f.ToString());
                                                    //int ghi = Convert.ToInt16(g.ToString() + h.ToString() + i.ToString());

                                                    int abc = a * 100 + b * 10 + c;
                                                    int def = d * 100 + e * 10 + f;
                                                    int ghi = g * 100 + h * 10 + i;

                                                    if (ghi - def == diff && def - abc == diff)
                                                    {
                                                        Console.WriteLine(abc.ToString() + def.ToString() + ghi.ToString());
                                                        counter++;
                                                    }
                                                    
                                                    
                                                }
                                            }

            if (counter == 0) Console.WriteLine("No");
        }
    }
}
