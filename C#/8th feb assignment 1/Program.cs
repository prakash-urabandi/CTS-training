using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8th_assignmenn_1
{
    class Program
    {
        static void Add(int x, int y)
        {
            Console.WriteLine("the sum is " + (x + y));
        }

        static void Subtract(int x, int y)
        {
            Console.WriteLine("the subtraction is " + (x - y));
        }

        static void Product(int x, int y)
        {
            Console.WriteLine("the product is " + (x * y));
        }

        static void Divide(int x, int y)
        {
            Console.WriteLine("the division is " + (x / y));
        }
        static void Main()
        {
            int choice;
            Console.WriteLine("Enter choice");
            choice = Convert.ToInt16(Console.ReadLine());

            if (choice == 1)
            {
                Add(30, 20);

            }
            else if (choice == 2)
            {
                Subtract(50, 30);


            }
            else if (choice == 3)
            {
                Product(10, 60);

            }
            else if (choice == 4)
            {
                Divide(40, 20);
            }

            else
                Console.WriteLine("Invalid choice");


        }
    }
}
