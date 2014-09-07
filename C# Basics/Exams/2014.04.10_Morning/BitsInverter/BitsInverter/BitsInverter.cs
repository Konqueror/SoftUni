using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitsInverter
{
    class BitsInverter
    {
        // convert int to bin
        public static string toBin(int value, int len)
        {
            return (len > 1 ? toBin(value >> 1, len - 1) : null) + "01"[value & 1];
        }

        // swap bits
        public static char swapBit(char c)
        {
            return (c == '1') ? '0' : '1';
        }

        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            byte step = byte.Parse(Console.ReadLine());
            int nextStep = 0;

            string bits = "";

            for (int i = 0; i < n;i++)
            {
                bits += toBin(int.Parse(Console.ReadLine()),8);
            }

            char[] tmp = bits.ToCharArray();

            while (nextStep < bits.Count())
            {
                tmp[nextStep] = swapBit(tmp[nextStep]);
                nextStep += step;
            }

            string bitsNew = new string(tmp);
            int nextNumber = 0;
            string tmpString = "";

            while (nextNumber < n*8)
            {
                tmpString = bitsNew.Substring(nextNumber, 8);
                Console.WriteLine(Convert.ToInt32(tmpString, 2));
                nextNumber += 8;
            }

        }
    }
}
