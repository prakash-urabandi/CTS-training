using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Employee
    {
        int Empid;
        string name, dept, Manager;
        double BasicSalary;
        int Exp;
        double DA, HRA, PF, NetSalary;

        public void GetEmployeeDetails()
        {
            Console.WriteLine("Enter Employee ID: ");
            Empid = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Employee Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Department: ");
            dept = Console.ReadLine();
            Console.WriteLine("Enter Manager Name: ");
            Manager = Console.ReadLine();
            Console.WriteLine("Enter Basic Salary: ");
            BasicSalary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Experience in years: ");
            Exp = Convert.ToInt16(Console.ReadLine());
        }
        public void CalculateSalary()
        {
            if (Exp <= 5)
            {
                DA = (1.9 * BasicSalary) / 100;
                HRA = (2.0 * BasicSalary) / 100;
                PF = 1200;
            }
            else if (Exp > 5 && Exp <= 7)
            {
                DA = (4.1 * BasicSalary) / 100;
                HRA = (3.8 * BasicSalary) / 100;
                PF = 1800;
            }
            else if (Exp > 7 && Exp <= 10)
            {
                DA = (7 * BasicSalary) / 100;
                HRA = (6.5 * BasicSalary) / 100;
                PF = 4100;
            }
            else if (Exp > 10)
            {
                DA = (10 * BasicSalary) / 100;
                HRA = (8.5 * BasicSalary) / 100;
                PF = 6200;
            }

            NetSalary = BasicSalary + DA + HRA - PF;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee ID = " + Empid);
            Console.WriteLine("Employee Name = " + name);
            Console.WriteLine("Basic Salary = " + BasicSalary);
            Console.WriteLine("DA = " + DA);
            Console.WriteLine("HRA = " + HRA);
            Console.WriteLine("PF = " + PF);
            Console.WriteLine("Net Salary = " + NetSalary);
        }
    }

    class Program1
    {
        static void Main()
        {
            Employee emp1 = new Employee();
            Employee emp2 = new Employee();
            Employee emp3 = new Employee();
            Employee emp4 = new Employee();
            Employee emp5 = new Employee();

            emp1.GetEmployeeDetails();
            emp2.GetEmployeeDetails();
            emp3.GetEmployeeDetails();
            emp4.GetEmployeeDetails();
            emp5.GetEmployeeDetails();

            emp1.CalculateSalary();
            emp2.CalculateSalary();
            emp3.CalculateSalary();
            emp4.CalculateSalary();
            emp5.CalculateSalary();

            emp1.DisplayEmployeeDetails();
            emp2.DisplayEmployeeDetails();
            emp3.DisplayEmployeeDetails();
            emp4.DisplayEmployeeDetails();
            emp5.DisplayEmployeeDetails();

        }
    }

// collections


using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstproject
{
    class employee
    {
        int empid, exp;
        string name, dept, manager;
        double basicsalary;
        double DA, HRA, PF, Netsalary;
        public void GetDetails()
        {
            Console.WriteLine("Enter Employee ID");
            empid = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter Name of the employee");
            name = Console.ReadLine();
            Console.WriteLine("Enter Department name");
            dept = Console.ReadLine();
            Console.WriteLine("Enter Manager name");
            manager = Console.ReadLine();
            Console.WriteLine("Enter Basic Salary");
            basicsalary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Experience of the employee");
            exp = Convert.ToByte(Console.ReadLine());
        }
        public void Calculatesal()
        {
            if (exp <= 5)
            {
                DA = (1.9 * basicsalary) / 100;
                HRA = (2.0 * basicsalary) / 100;
                PF = 1200;
            }
            else if (exp > 5 && exp <= 7)
            {
                DA = (4.1 * basicsalary) / 100;
                HRA = (3.8 * basicsalary) / 100;
                PF = 1800;
            }
            else if (exp > 7 && exp <= 10)
            {
                DA = (7 * basicsalary) / 100;
                HRA = (6.5 * basicsalary) / 100;
                PF = 4100;
            }
            else if (exp > 10)
            {
                DA = (10 * basicsalary) / 100;
                HRA = (8.5 * basicsalary) / 100;
                PF = 6200;
            }
            Netsalary = (basicsalary + DA + HRA) - PF;
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("employeeid is" + empid);
            Console.WriteLine("Name of the employee is" + name);
            Console.WriteLine("Department name is" + dept);
            Console.WriteLine("manager name is" + manager);
            Console.WriteLine("Basic Salary is" + basicsalary);
            Console.WriteLine("Experience of the employee is" + exp);
            Console.WriteLine("DA is" + DA);
            Console.WriteLine("HRA is" + HRA);
            Console.WriteLine("PF is" + PF);
            Console.WriteLine("Net salary is" + Netsalary);
        }
    }
    class assclasses
    {
        static void Main()
        {
            ArrayList list = new ArrayList();
            employee employee1 = new employee();
            list.Add(employee1);
            employee employee2 = new employee();
            list.Add(employee2);
            employee employee3 = new employee();
            list.Add(employee3);
            employee employee4 = new employee();
            list.Add(employee4);
            employee employee5 = new employee();
            list.Add(employee5);

            foreach (employee emp in list)
            {
                emp.GetDetails();
                emp.Calculatesal();
                emp.DisplayEmployeeDetails();
            }

        }
    }
}

// generic collections

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9th_feb_ssmt_1
{
    class generic_collections
    {
        class employee
        {
            int empid;
             int exp;
            string name;
            string dept; 
            string manager;
            double basicsalary;
            double DA, HRA, PF, Netsalary;
            public void GetDetails()
            {
                Console.WriteLine("Enter Employee ID");
                empid = Convert.ToByte(Console.ReadLine());
                Console.WriteLine("Enter Name of the employee");
                name = Console.ReadLine();
                Console.WriteLine("Enter Department name");
                dept = Console.ReadLine();
                Console.WriteLine("Enter Manager name");
                manager = Console.ReadLine();
                Console.WriteLine("Enter Basic Salary");
                basicsalary = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Experience of the employee");
                exp = Convert.ToByte(Console.ReadLine());
            }
            public void Calculatesal()
            {
                if (exp <= 5)
                {
                    DA = (1.9 * basicsalary) / 100;
                    HRA = (2.0 * basicsalary) / 100;
                    PF = 1200;
                }
                else if (exp > 5 && exp <= 7)
                {
                    DA = (4.1 * basicsalary) / 100;
                    HRA = (3.8 * basicsalary) / 100;
                    PF = 1800;
                }
                else if (exp > 7 && exp <= 10)
                {
                    DA = (7 * basicsalary) / 100;
                    HRA = (6.5 * basicsalary) / 100;
                    PF = 4100;
                }
                else if (exp > 10)
                {
                    DA = (10 * basicsalary) / 100;
                    HRA = (8.5 * basicsalary) / 100;
                    PF = 6200;
                }
                Netsalary = (basicsalary + DA + HRA) - PF;
            }
            public void DisplayEmployeeDetails()
            {
                Console.WriteLine("employeeid is" + empid);
                Console.WriteLine("Name of the employee is" + name);
                Console.WriteLine("Department name is" + dept);
                Console.WriteLine("manager name is" + manager);
                Console.WriteLine("Basic Salary is" + basicsalary);
                Console.WriteLine("Experience of the employee is" + exp);
                Console.WriteLine("DA is" + DA);
                Console.WriteLine("HRA is" + HRA);
                Console.WriteLine("PF is" + PF);
                Console.WriteLine("Net salary is" + Netsalary);
            }
        }
        class assclasses
        {
            static void Main()
            {
                List<employee> list = new List<employee>();
                employee employee1 = new employee();
                list.Add(employee1);
                employee employee2 = new employee();
                list.Add(employee2);
                employee employee3 = new employee();
                list.Add(employee3);
                employee employee4 = new employee();
                list.Add(employee4);
                employee employee5 = new employee();
                list.Add(employee5);
                foreach (employee emp in list)
                {
                    emp.GetDetails();
                    emp.Calculatesal();
                    emp.DisplayEmployeeDetails();
                }

            }
        }
    }
}



