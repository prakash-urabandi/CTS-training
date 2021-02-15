
using System;

namespace _5th_feb_assmt_2
{
    class program
    {
        static void Main(string[] args)
        {
            //  add three numbers 

            Console.WriteLine("Enter Three Numbers:");
            int number1 = Convert.ToInt16(Console.ReadLine());
            int number2 = Convert.ToInt16(Console.ReadLine());
            int number3 = Convert.ToInt16(Console.ReadLine());
            int total = (number1 + number2 + number3);
            Console.WriteLine("The total number is : " +total);


    


        }
    }
}
