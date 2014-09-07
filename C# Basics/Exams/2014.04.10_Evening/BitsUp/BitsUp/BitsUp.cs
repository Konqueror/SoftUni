using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitsUp
{
    class BitsUp
    {
        // convert int to bin
        public static string toBin(int value, int len=8)
        {
            return (len > 1 ? toBin(value >> 1, len - 1) : null) + "01"[value & 1];
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());
            string binBlob = "";
            int nextStep = 1;

            for (int i = 0; i<n; i++)
            {
                binBlob += toBin(int.Parse(Console.ReadLine()));
            }

            char[] tmp = binBlob.ToCharArray();

            while (nextStep < binBlob.Count())
            {
                tmp[nextStep] = '1';
                nextStep += step;
            }

            string bitsNew = new string(tmp);
            int nextNumber = 0;
            string tmpString = "";

            while (nextNumber < n * 8)
            {
                tmpString = bitsNew.Substring(nextNumber, 8);
                Console.WriteLine(Convert.ToInt32(tmpString, 2));
                nextNumber += 8;
            }

        }
    }
}
