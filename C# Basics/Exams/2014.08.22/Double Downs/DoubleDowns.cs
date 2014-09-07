using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleDowns
{
    class DoubleDowns
    {

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] numbers = new string[n];

            int vertical = 0;
            int right = 0;
            int left = 0;

            for (int i = 0; i < n; i++)
            {

                numbers[i] = Convert.ToString(int.Parse(Console.ReadLine()), 2).PadLeft(32, '0');
            }

            for (int i=0; i<n-1;i++)
            {
                    // vertical
                    for (int p =0; p<32;p++)
                    {
                        if (numbers[i][p] == numbers[i+1][p] && numbers[i][p] == '1')
                        {
                            vertical++;
                        }
                    }

                    // right
                    for (int p = 0; p < 31; p++)
                    {
                        if (numbers[i][p] == numbers[i + 1][p+1] && numbers[i][p] == '1')
                        {
                            right++;
                        }
                    }

                    // left
                    for (int p = 1; p < 32; p++)
                    {
                        if (numbers[i][p] == numbers[i + 1][p-1] && numbers[i][p] == '1')
                        {
                            left++;
                        }
                    }
                    
            }

            Console.WriteLine(right);
            Console.WriteLine(left);
            Console.WriteLine(vertical);

        }
    }
}
