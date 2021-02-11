using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_and_diff
{
    class primenumber
    {
        static void Main()
        {
            int Count = 0;
            int b, num;
            Console.WriteLine("Enter a number");
            num = Convert.ToByte(Console.ReadLine());
            for (b = 1; b <= num; b++)
            {
                if (num % b == 0)
                    Count++;
            }
            if (Count == 2)
            {
                Console.WriteLine("The given number is a prime number");
            }
            else
            {
                Console.WriteLine("The given number is not a prime number");
            }
        }
    }
}
