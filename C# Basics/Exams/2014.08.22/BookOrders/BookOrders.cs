using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookOrders
{
    class BookOrders
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());
            int books = 0;
            double price = 0.0;

            int booksPerPackage = 0;
            int numberPackages = 0;
            double priceForBook = 0.0;

            for (int i=0; i<orders; i++)
            {
                numberPackages = int.Parse(Console.ReadLine());
                booksPerPackage = int.Parse(Console.ReadLine());
                priceForBook = double.Parse(Console.ReadLine());

                books += booksPerPackage*numberPackages;

                if (numberPackages < 10)
                {
                    price += booksPerPackage*numberPackages*priceForBook;
                } 
                else if (numberPackages >= 10 && numberPackages < 20)
                {
                    price += booksPerPackage*numberPackages*priceForBook*0.95;
                }
                else if (numberPackages >= 20 && numberPackages < 30)
                {
                    price += booksPerPackage*numberPackages*(priceForBook*0.94);
                }
                else if (numberPackages >= 30 && numberPackages < 40)
                {
                    price += booksPerPackage*numberPackages*priceForBook*0.93;
                }

                else if (numberPackages >= 40 && numberPackages < 50)
                {
                    price += booksPerPackage*numberPackages*priceForBook*0.92;
                }

                else if (numberPackages >= 50 && numberPackages < 60)
                {
                    price += booksPerPackage*numberPackages*priceForBook*0.91;
                }

                else if (numberPackages >= 60 && numberPackages < 70)
                {
                    price += booksPerPackage*numberPackages*priceForBook*0.90;
                }

                else if (numberPackages >= 70 && numberPackages < 80)
                {
                    price += booksPerPackage*numberPackages*priceForBook*0.89;
                }

                else if (numberPackages >= 80 && numberPackages < 90)
                {
                    price += booksPerPackage*numberPackages*priceForBook*0.88;
                }

                else if (numberPackages >= 90 && numberPackages < 100)
                {
                    price += booksPerPackage*numberPackages*priceForBook*0.87;
                }

                else if (numberPackages >= 100 && numberPackages < 110)
                {
                    price += booksPerPackage*numberPackages*priceForBook*0.86;
                }

                else if (numberPackages >= 110)
                {
                    price += booksPerPackage * numberPackages * priceForBook * 0.85;
                }

                
            }

            Console.WriteLine(books);
            Console.WriteLine("{0:0.00}", price);

        }
    }
}
