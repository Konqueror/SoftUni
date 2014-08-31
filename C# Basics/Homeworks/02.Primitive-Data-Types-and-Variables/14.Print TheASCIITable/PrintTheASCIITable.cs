using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_TheASCIITable
{
    class PrintTheASCIITable
    {
        static void Main(string[] args)
        {
            for (char i = ' '; i <= '~'; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
