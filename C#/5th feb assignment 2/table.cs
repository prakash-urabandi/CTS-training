using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_and_diff
{
    class table
    {
        static void main()
        {

            int num, e;
            Console.WriteLine("Enter an Integer");
            num = Convert.ToByte(Console.ReadLine());
            for (e = 1; e <= 10; e++)
            {
                Console.WriteLine("{0} x {1} = {2} ", num, e, num * e);
            }
        }
    }
}
