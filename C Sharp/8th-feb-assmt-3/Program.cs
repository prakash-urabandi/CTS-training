using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8th_feb_assmt_3
{
    class Program
    {
        // count a total number of duplicate elements in an array
        static void Main()
        {
            int[] num = new int[10];
            int count = 0;
            Console.WriteLine("Enter 10 numbers:");
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = Convert.ToInt16(Console.ReadLine());
            }

            for (int i = 0; i < num.Length; i++)
            {
                for (int j = i + 1; j < num.Length; j++)
                {
                    if (num[i] == num[j])
                    {
                        count++;
                        break;
                    }
                }
            }
            Console.WriteLine("The duplicate elements are : " + count);
        }
    }
}
