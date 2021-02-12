using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5th_feb_assmt_2
{
    class table
    {

        static void Main()
        {
            // print table

            int i, number;
            Console.WriteLine("Enter number \n");
            number = Convert.ToInt16(Console.ReadLine());

            for (i = 1; i <= 10; i++)
            {
                Console.Write("{0} X {1} = {2} \n", number, i, number * i);
            }

        }
    }
}
