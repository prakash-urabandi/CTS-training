using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8th_assignmenn_1
{
    class electricitybill
    {
        static void Main()
        {
            String name, IDNO;
            int unit;
            double Amount = 0;
            double subcharge = 0, net_amnt;
            Console.WriteLine("Enter customer id");
            IDNO = Console.ReadLine();
            Console.WriteLine("Enter Customer name");
            name = Console.ReadLine();
            Console.WriteLine("Enter units consumed");
            unit = Convert.ToInt32(Console.ReadLine());
            if (unit <= 199)
            {
                Amount = (1.20 * unit);
                Console.WriteLine("Amount is" + Amount);
            }
            else if (unit > 200 && unit < 400)
            {
                Amount = (1.50 * unit);
                Console.WriteLine("Amount is" + Amount);
            }
            else if (unit >= 400 && unit < 600)
            {
                Amount = (1.80 * unit);
                Console.WriteLine("Amount is" + Amount);
            }
            else if (unit >= 600)
            {
                Amount = (2.00 * unit);
                Console.WriteLine("Amount is" + Amount);
            }
            if (Amount > 400)
            {
                subcharge = ((15 * Amount) / 100);
            }
            Console.WriteLine("Subcharge amount is" + subcharge);
            net_amnt = Amount + subcharge;
            if (net_amnt < 100)
            {
                net_amnt = 100;
            }
            Console.WriteLine("Net amount paid by the customer:{0:N2}", net_amnt);



        }
    }
}
