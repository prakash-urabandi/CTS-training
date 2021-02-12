using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8th_feb_assmt_2
{
    class Program
    {

        // Print sum and average of elements of an Array

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
            Console.WriteLine("Sum is :" + sum);
            Console.WriteLine("Average is :" + avg);
        }

    }
}
