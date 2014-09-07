using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tables
{
    class Tables
    {
        static void Main(string[] args)
        {
            long bundle1 = long.Parse(Console.ReadLine());
            long bundle2 = long.Parse(Console.ReadLine());
            long bundle3 = long.Parse(Console.ReadLine());
            long bundle4 = long.Parse(Console.ReadLine());

            long legs = bundle1 * 1 + bundle2 * 2 + bundle3 * 3 + bundle4 * 4;

            long tableTops = long.Parse(Console.ReadLine());
            long tables = long.Parse(Console.ReadLine());

            long legsNeeded = 0;
            long legsMore = 0;

            if (legs < tables*4)
            {
                legsNeeded = tables * 4 - legs;
            }
            if (tables*4 < legs)
            {
                legsMore = legs - tables* 4;
            }

            if (tables <= tableTops && tables * 4 == legs || tables == tableTops && tables * 4 <= legs)
            {
                Console.WriteLine("Just enough tables made: {0}", tables);
            } 

            else if (tables > tableTops || tables*4 > legs)
            {

                Console.WriteLine("less: -{0}", tables - tableTops);
                
                Console.WriteLine("tops needed: {0}, legs needed: {1}", tables-tableTops, legsNeeded);
            } 

            else if (tables < tableTops && legs >= tableTops*4)
            {
                Console.WriteLine("more: {0}", tableTops - tables);

                Console.WriteLine("tops left: {0}, legs left: {1}", tableTops-tables, legsMore);
            }

        }
    }
}
