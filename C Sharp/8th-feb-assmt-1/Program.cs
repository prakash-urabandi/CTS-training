using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asss1
{
    class Program
    {
        static void Addition(int x, int y)
        {
            Console.WriteLine(" addittion  is " + (x + y));
        }
        static void Subtraction(int x, int y)
        {
            Console.WriteLine("Subtraction is " + (x - y));
        }

        static void Product(int x, int y)
        {
            Console.WriteLine("Product  is " + (x * y));
        }


        static void Division(float x, float y)
        {
            Console.WriteLine("Division is " + (x / y));
        }

        //     USING IF ELSE
        static void Main()
        {
            Console.WriteLine("Using If Else statements\n");
            Console.WriteLine("enter two numbers\n");
            int x = Convert.ToInt16(Console.ReadLine());
            int y = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter the value to perform specific opearton \n");
            int choice = Convert.ToInt16(Console.ReadLine());
            if (choice == 1)
            {
                Addition(x, y);
            }
            else if (choice == 2)
            {
                Subtraction(x, y);
            }

            else if (choice == 3)
            {
                Product(x, y);
            }
            else if (choice == 4)
            {
                Division(x, y);
            }
            else
            {
                Console.WriteLine("invalid choice");
            }
            //    USING SWITCH

            Console.WriteLine("Using Switch statement\n");
            Console.WriteLine("Enter two values \n");
            int a = Convert.ToInt16(Console.ReadLine());
            int b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter the value tp perform opearton on a and b\n");
            int choice1 = Convert.ToInt16(Console.ReadLine());

            switch (choice1)
            {
                case 1:
                    Addition(a, b);
                    break;
                case 2:
                    Subtraction(a, b);
                    break;
                case 3:
                    Product(a, b);
                    break;
                case 4:
                    Division(a, b);
                    break;
                default:
                    Console.WriteLine("invalid choice1");
                    break;

            }
        }
    }
}




