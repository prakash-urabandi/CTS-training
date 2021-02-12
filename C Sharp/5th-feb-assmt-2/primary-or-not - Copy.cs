using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5th_feb_assmt_2
{
    class prime_or_not

    {
        public static void Main()
        {

            int flag = 0, num;
            Console.WriteLine("Enter the number here:");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    flag = 0;
                    break;
                }
                else
                    flag = 1;
            }
            if (flag == 1)
                Console.WriteLine(num + " is a prime number");
            else
                Console.WriteLine(num + " is not a prime number");
        }
    }
    
}
