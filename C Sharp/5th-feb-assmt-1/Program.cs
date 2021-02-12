

using System;


namespace _5_feb_assm_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // add three numbers

            int number1 = 20;
            int number2 = 40;
            int number3 = 60;
             int total = number1 + number2 + number3;
            Console.WriteLine(total);

            // multiply three numbers

            int number4 = 2;
            int number5 = 3;
            int number6 = 4;
            int multiply = (number4 * number5 * number6);
            Console.WriteLine(multiply);

            // declare string and integer variables to hold id, name , address , salary   Display it in              

            int id = 5199;
            string name = "raju";
            string address = "guntur";
            int salary = 25000;
            Console.WriteLine("your id is :" +id);
            Console.WriteLine("Your name is : " +name );
            Console.WriteLine("Your Address is : "+address);
            Console.WriteLine("Your Salary is :"+salary);


        }
    }
}
