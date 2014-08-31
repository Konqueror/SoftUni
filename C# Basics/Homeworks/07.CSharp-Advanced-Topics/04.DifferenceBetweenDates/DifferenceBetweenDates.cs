using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DifferenceBetweenDates
{
    class DifferenceBetweenDates
    {
        static void Main(string[] args)
        {
            DateTime firstDate = DateTime.Parse(Console.ReadLine());
            DateTime secondDate = DateTime.Parse(Console.ReadLine());
            TimeSpan daysInBetween = secondDate - firstDate;
            bool check = (firstDate <= secondDate);

            if (check)
            {
                Console.WriteLine("{0:%d}", daysInBetween);
            }
            else
            {
                Console.WriteLine("-{0:%d}", daysInBetween);
            }
        }
    }
}
