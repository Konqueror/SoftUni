using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";

            object HelloWorldObject = hello + " " + world;
            string HelloWorldString = (string)HelloWorldObject;

            Console.WriteLine(HelloWorldString);
        }
    }
}
