using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8th_assignmenn_1
{
    class sum_and_avg
    {
        static void Main()
        {
            int[] num = new int[] { 1, 2, 3, 4, 5 };
            int sum = 0;
            float avg;

            for (int i = 0; i < num.Length; i++)
            {
                sum += num[i];
            }

            avg = (float)sum / 10;
            Console.WriteLine("Sum is " + sum);
            Console.WriteLine("Average is " + avg);
        }
    }
}
