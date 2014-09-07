using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddAndEvenJumps
{
    class OddAndEvenJumps
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            inputString = inputString.ToLower();
            inputString = inputString.Replace(" ","");
            int oddJump = int.Parse(Console.ReadLine());
            int evenJump = int.Parse(Console.ReadLine());

            int oddJumpStep = oddJump;
            int evenJumpStep = evenJump;

            string oddString = "";
            string evenString = "";

            ulong odd = 0;
            ulong even = 0;

            bool isOdd = true;

            for (int i = 0; i < inputString.Length; i++)
            {
                if (isOdd)
                {
                    oddString += inputString[i];
                    isOdd = false;
                }
                else
                {
                    evenString += inputString[i];
                    isOdd = true;
                }
            }

            for (int i = 0; i < oddString.Length; i++)
            {
                if (i+1 != oddJump)
                {
                    odd += (ulong)oddString[i];
                }
                else
                {
                    odd *= (ulong)oddString[i];
                    oddJump += oddJumpStep;
                }
                
            }

            for (int i = 0; i < evenString.Length; i++)
            {
                if (i + 1 != evenJump)
                {
                    even += (ulong)evenString[i];
                }
                else
                {
                    even *= (ulong)evenString[i];
                    evenJump += evenJumpStep;
                }

            }

            Console.WriteLine("Odd: " + odd.ToString("X"));
            Console.WriteLine("Even: " + even.ToString("X"));
        }
    }
}
