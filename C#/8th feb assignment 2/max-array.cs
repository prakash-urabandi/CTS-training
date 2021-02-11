using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8th_assignmenn_1
{
    class max_array
    {
        static void Main()
        {
            int[] num = new int[10];
            Console.WriteLine("Enter 10 numbers:");

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = Convert.ToInt16(Console.ReadLine());
            }

            int max = num[0];

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] > max)
                    max = num[i];
            }
            Console.WriteLine("Maximum element of this array is " + max);
        }
    }
}
