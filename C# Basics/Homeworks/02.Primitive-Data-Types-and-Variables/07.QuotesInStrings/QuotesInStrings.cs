using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuotesInStrings
{
    class QuotesInStrings
    {
        static void Main(string[] args)
        {
            string stringWithQuotes = "The \"use\" of quotations causes difficulties.";
            string stringWithoutQuotes = "The \u0022use\u0022 of quotations causes difficulties.";

            Console.WriteLine(stringWithQuotes);
            Console.WriteLine(stringWithoutQuotes);
        }
    }
}
