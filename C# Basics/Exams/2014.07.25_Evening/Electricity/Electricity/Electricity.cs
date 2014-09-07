using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electricity
{
    class Electricity
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int flats = int.Parse(Console.ReadLine());
            double watts = 0;

            string timeString = Console.ReadLine();

            timeString = timeString.Replace(":","");

            
            int time = Convert.ToInt32(timeString);

            if (time >= 1400 && time <= 1859)
            {
                // case 1
                watts = (2 * 100.53 + 2 * 125.9)*floors*flats;
            }
            else if (time >= 1900 && time <= 2359)
            {
                // case 2
                watts = (7 * 100.53 + 6 * 125.9) * floors * flats;
            }
            else if (time >= 0 && time <= 859)
            {
                // case 3
                watts = (1 * 100.53 + 8 * 125.9) * floors * flats;
            }

            Console.WriteLine((int)watts + " Watts");
            
        }
    }
}
