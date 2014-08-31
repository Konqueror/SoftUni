using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.CountNames
{
    class CountNames
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>(Console.ReadLine().Split(' '));
            Dictionary<string, int> finalCount = new Dictionary<string, int>();
            names.Sort();
            
            finalCount[names[0]] = 1;
            int countTemp = 1;

            for (int i = 1; i < names.Count; i++)
            {
                string currentLetter = names[i];
                string previousLetter = names[i - 1];
                if (currentLetter == previousLetter)
                {
                    countTemp++;
                    finalCount[names[i]] = countTemp;
                }
                else
                {
                    countTemp = 1;
                    finalCount[names[i]] = countTemp;
                }
            }
            
            foreach (var entry in finalCount)
            {
                Console.WriteLine("{0} --> {1}", entry.Key, entry.Value);
            }
        }
    }
}
