using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8th_feb_assmt_2
{
    class _3_by__3_matrix
    {
        // display sum of 3 * 3 matrix

        static void Main()
        {
            int[,] num = new int[3, 3];
            int sum = 0;
            Console.WriteLine("Enter the numbers:");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    num[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sum += num[i, j];
                }
            }
            Console.WriteLine("Sum is " + sum);
        }

    }
    
}