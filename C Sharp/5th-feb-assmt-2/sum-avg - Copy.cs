using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5th_feb_assmt_2
{
    class sum_avg
    {
        public static void Main()
        {

            // print sum and average of 1st 20 natural numbers


            float sum = 0;
            for (int i = 1; i <= 20; i++)
            {
                sum = sum + i;
            }
            float average = sum / 20;
            Console.WriteLine("The sum of the first 20 natural numbers are :" + sum);
            Console.WriteLine("The average of the first 20 natural numbers are" + average);
        }
    }
}
