using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8th_feb_assmt_3
{
    class eligibulity_for_admission
    {
        static void Main()
        {
            int maths, physics, chemistry, total, total_math_phy;
            Console.Write("Input the marks obtained in Physics :");
            physics = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the marks obtained in Chemistry :");
            chemistry = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the marks obtained in Mathematics :");
            maths = Convert.ToInt32(Console.ReadLine());
            total = maths + physics + chemistry;
            total_math_phy = maths + physics;

            if ((maths >= 65) && (physics >= 55) && (chemistry >= 50))
            {
                if ((total >= 180) || (total_math_phy >= 140))
                    Console.WriteLine("\nThe candidate is eligible for admission.");
            }
            else
                Console.WriteLine("The candidate is not eligible for admission.");
        }
    }
}
