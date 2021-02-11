using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_and_diff
{
    class evennumbers
    {
        static void Main()
        {
            Console.WriteLine("The first 50 even numbers are");
            for (int i = 2; i <= 50; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
