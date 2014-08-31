using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.LongestWord
{
    class LongestWord
    {
        static void Main(string[] args)
        {
             string someText = Console.ReadLine();
            string[] allWords = someText.Split(new char[] { ' ', ',', ':', ';', '.' },
            StringSplitOptions.RemoveEmptyEntries);
            int longestWordIndex = 0;

            for (int i = 1; i < allWords.Length; i++)
            {
                if (allWords[i].Length > allWords[longestWordIndex].Length)
                {
                    longestWordIndex = i;
                }
            }

            Console.WriteLine(allWords[longestWordIndex]);

        }
    }
}
