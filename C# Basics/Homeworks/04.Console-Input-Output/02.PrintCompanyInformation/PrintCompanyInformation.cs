using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintCompanyInformation
{
    class PrintCompanyInformation
    {
        static void Main(string[] args)
        {
            Console.Write("Company name: ");
            string companyName = Console.ReadLine();

            Console.Write("Company address: ");
            string companyAddress = Console.ReadLine();

            Console.Write("Phone number: ");
            string companyPhone = Console.ReadLine();

            Console.Write("Fax number: ");
            string companyFax = Console.ReadLine();

            Console.Write("Web site: ");
            string companySite = Console.ReadLine();

            Console.Write("Manager first name: ");
            string managerFirstName = Console.ReadLine();

            Console.Write("Manager last name: ");
            string managerLastName = Console.ReadLine();

            Console.Write("Manager age: ");
            string managerAge = Console.ReadLine();

            Console.Write("Manager phone: ");
            string managerPhone = Console.ReadLine();

            // check if there is no fax or empty
            if (string.IsNullOrEmpty(companyFax))
            {
                companyFax = "(no fax)";
            }

            Console.WriteLine(companyName);
            Console.WriteLine("Address: " + companyAddress);
            Console.WriteLine("Tel. " + companyPhone);
            Console.WriteLine("Fax: " + companyFax);
            Console.WriteLine("Website: " + companySite);
            Console.WriteLine("Manager: " + managerFirstName + " " + managerLastName + " (age: " + managerAge + ", tel. " + managerPhone + ")");

        }
    }
}
