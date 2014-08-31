using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GravitationOnTheMoon
{
    class GravitationOnTheMoon
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Person's weight on Earth (in kg):");

            double weightEarth = double.Parse(Console.ReadLine());
            double weightMoon = (weightEarth * 0.17);
            double weightMoonRound = Math.Round(weightMoon, 3);

            Console.WriteLine("The person will weight " + weightMoonRound + "kg on the Moon.");
        }
    }
}
