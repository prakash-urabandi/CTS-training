using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8th_assignmenn_1
{
    class eligibulity
    {

        static void Main()
        {
            int Maths, Phy, Chem;
            Console.WriteLine("Enter Maths marks");
            Maths = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Physics marks");
            Phy = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("EnterChemistry marks");
            Chem = Convert.ToInt16(Console.ReadLine());
            int T1 = Maths + Phy + Chem;
            int T2 = Maths + Phy;
            if (Maths >= 65 && Phy >= 55 && Chem >= 50)
            {
                if (T1 >= 180 || T2 >= 140)
                {
                    Console.WriteLine("The candidate is eligible for admission");
                }
            }
            else
            {
                Console.WriteLine("Candidate is not eligible");
            }


        }
    }
}
