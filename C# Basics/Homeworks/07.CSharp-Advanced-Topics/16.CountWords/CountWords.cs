using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.CountWords
{
    class CountWords
    {
        static void Main(string[] args)
        {
            string givenWord = Console.ReadLine();
            string text = Console.ReadLine();

            foreach (char c in text)
            {
                if (!((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z')))
                {
                    text = text.Replace(c, ' ');
                }
            }

            string[] list = text.Split(' ');
            int counter = 0;

            foreach (string word in list)
            {
                if (word.ToLower() == givenWord.ToLower())
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
