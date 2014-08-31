using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.CountLetters
{
    class CountLetters
    {
        static void Main(string[] args)
        {
            List<string> letters = new List<string>(Console.ReadLine().Split(' '));
            Dictionary<string, int> finalCount = new Dictionary<string, int>();
            letters.Sort();
            
            finalCount[letters[0]] = 1;
            int countTemp = 1;

            for (int i = 1; i < letters.Count; i++)
            {
                string currentLetter = letters[i];
                string previousLetter = letters[i - 1];
                if (currentLetter == previousLetter)
                {
                    countTemp++;
                    finalCount[letters[i]] = countTemp;
                }
                else
                {
                    countTemp = 1;
                    finalCount[letters[i]] = countTemp;
                }
            }
            
            foreach (var entry in finalCount)
            {
                Console.WriteLine("{0} --> {1}", entry.Key, entry.Value);
            }
        }
    }
}
