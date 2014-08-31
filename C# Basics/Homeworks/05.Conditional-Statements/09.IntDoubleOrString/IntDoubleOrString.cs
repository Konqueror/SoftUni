using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntDoubleOrString
{
    class IntDoubleOrString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a type: 1 (int) | 2 (double) | 3 (string)");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    {
                        Console.Write("Please, enter an integer: ");
                        int n = int.Parse(Console.ReadLine());
                        n += 1;
                        Console.WriteLine(n);
                        break;
                    }
                case 2:
                    {
                        Console.Write("Please, enter a double: ");
                        double n = double.Parse(Console.ReadLine());
                        n += 1;
                        Console.WriteLine(n);
                        break;
                    }
                case 3:
                    {
                        Console.Write("Please, enter a string: ");
                        string n = Console.ReadLine();
                        n = (n + "*");
                        Console.WriteLine(n);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("invalid choice");
                        break;
                    }
            }
        }
    }
}
