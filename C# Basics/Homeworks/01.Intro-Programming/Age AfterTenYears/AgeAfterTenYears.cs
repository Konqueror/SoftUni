using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_AfterTenYears
{
    class AgeAfterTenYears
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter your birtday (format: mm/dd/yyyy): ");

            // reads your birthday and convert it to datetime format
            DateTime bday = Convert.ToDateTime(Console.ReadLine());

            // today in datetime format
            DateTime today = DateTime.Today;

            // calculating current age
            int age = today.Year - bday.Year;
            if (bday > today.AddYears(-age)) age--; // fix

            // printing your age now
            Console.WriteLine("Your current age: " + age);

            // printing your age after 10 years
            Console.WriteLine("Your age after 10 years: " + (age+10));

        }
    }
}
