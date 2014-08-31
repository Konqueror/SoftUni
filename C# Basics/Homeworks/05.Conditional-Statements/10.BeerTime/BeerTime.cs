using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace BeerTime
{
    class BeerTime
    {
        static void Main(string[] args)
        {
            Console.Write("Enter time (hh:mm tt - for example 08:00 AM): ");
            string input = Console.ReadLine();

            DateTime time = DateTime.Now;

            try
            {
                DateTime.TryParseExact(input, "hh:mm tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out time);
            }
            catch (Exception)
            {
                Console.WriteLine("invalid time");
            }

            string startBeer = "01:00 PM";
            DateTime startBeerTime = DateTime.Now;
            DateTime.TryParseExact(startBeer, "hh:mm tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out startBeerTime);

            string endBeer = "03:00 AM";
            DateTime endBeerTime = DateTime.Now;
            DateTime.TryParseExact(endBeer, "hh:mm tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out endBeerTime);

            if ((time < endBeerTime) || (time > startBeerTime))
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }
        }
    }
}
