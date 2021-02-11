using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_and_diff
{
    class Program
    {

        static void Main()
        {
            float sum = 0;
            for (int i = 1; i <= 20; i++)
            {
                sum = sum + i;
            }
            float average = sum / 20;
            Console.WriteLine("The sum of the first 20 natural numbers is {0} ", sum);
            Console.WriteLine("The average of the first 20 natural numbers is {0} ", average);
        }
    }
}
