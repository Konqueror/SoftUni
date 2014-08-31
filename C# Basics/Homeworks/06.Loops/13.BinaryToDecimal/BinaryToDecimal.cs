using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter binary number: ");
            string nBinaryString = Console.ReadLine();

            int[] nBinaryArray = new int[nBinaryString.Length];

            for (int i = 0; i < nBinaryString.Length; i++)
            {
                nBinaryArray[i] = Convert.ToInt32(Convert.ToString(nBinaryString[i]));
            }

            Array.Reverse(nBinaryArray);
            double nDecimal = 0;

            for (int j = 0; j < nBinaryString.Length; j++)
            {
                if (nBinaryArray[j] == 1)
                {
                    nDecimal += Math.Pow(2, j);
                }
                else
                {
                    nDecimal = nDecimal + 0;
                }
            }

            long nDecimalLong = Convert.ToInt64(nDecimal);

            Console.WriteLine(nDecimalLong);
        }
    }
}
