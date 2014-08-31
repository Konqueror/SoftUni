using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MatrixOfPalindromes
{
    class MatrixOfPalindromes
    {
        static void Main(string[] args)
        {
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            string[] alphabet = { "0", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            
            for (int i = 1; i <= r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write("{0}{1}{0} ", alphabet[i], alphabet[i + j]);
                }
                Console.WriteLine();
            }
        }
    }
}
