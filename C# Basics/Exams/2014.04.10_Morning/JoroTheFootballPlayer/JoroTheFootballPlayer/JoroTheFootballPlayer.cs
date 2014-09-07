using System;

namespace JoroTheFootballPlayer
{
    class JoroTheFootballPlayer
    {
        static void Main(string[] args)
        {
            bool leapYear = false;
            ushort p = 0;
            ushort h = 0;

            if ( Console.ReadLine() == "t" )
            {
                leapYear = true;
            }

            p = ushort.Parse(Console.ReadLine());
            h = ushort.Parse(Console.ReadLine());

            if (!leapYear)
            {
                // not leap year
                Console.WriteLine( (p / 2) + (2*(52 - h) / 3) + h );
            } else
                {
                    // leap year
                    Console.WriteLine( (p / 2) + (2*(52 - h) / 3) + h + 3 );
                }

        }
    }
}
