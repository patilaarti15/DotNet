using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment05
{
    class Program
    {
        static void Main1(string[] args)
        {
            Dictionary<int, Employees> di = new Dictionary<int, Employees>();
            char choice = 'y';
            while (choice == 'y')
            {
                Employees.insertEmployee(di);
                Console.Write("Do you Want to continue type (y/n) : ");
                choice = Convert.ToChar(Console.ReadLine());

            }


            Employees.highSalary(di);

            Employees.empSearch(di);

            Console.Write("Enter Number of Employee ");
            int no = Convert.ToInt32(Console.ReadLine());
            int tmp = 1;
            foreach (KeyValuePair<int, Employees> i in di)
            {

                Console.WriteLine(i.Key + " : " + i.Value.EmpId + "  " + "  " + i.Value.EmpName + "  " + i.Value.EmpSal);
                if (no == tmp) break;
                ++tmp;
            }

            Console.ReadLine();
        }

        class Employees
        {
            private int empId;

            private string empName;
            private decimal empSal;
            public static int empKey = 0;
            public int EmpId
            {
                get { return empId; }
                set { if (value > 0) empId = value; else Console.WriteLine("Enter Valid empId"); }
            }
            public string EmpName
            {
                get { return empName; }
                set { if (value == null) Console.WriteLine("Enter Valid empName"); else empName = value; }
            }
            public decimal EmpSal
            {
                get { return empSal; }
                set { if (value < 10000) Console.WriteLine("Enter valid Emp sal "); else empSal = value; }
            }

            public Employees(int empId, string empName, decimal empSal)
            {
                this.EmpId = empId;
                this.EmpName = empName;
                this.EmpSal = empSal;
            }

            public static void insertEmployee(Dictionary<int, Employees> di)
            {

                Console.WriteLine("-------------------------------------------------");
                Console.Write("Enter Employee Id : ");
                int empId = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Employee Name : ");
                string empName = Console.ReadLine();
                Console.Write("Enter Employee Sal : ");
                decimal empSal = Convert.ToDecimal(Console.ReadLine());
                di.Add(++empKey, new Employees(empId, empName, empSal));
            }

            public static void highSalary(Dictionary<int, Employees> di)
            {
                decimal[] sal = new decimal[di.Count];
                int ii = 0;
                foreach (KeyValuePair<int, Employees> i in di)
                {
                    sal[ii] = (decimal)i.Value.EmpSal;
                    Console.WriteLine(i.Key + " " + i.Value.EmpName);
                    ii++;
                }
                Array.Sort(sal);
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("High sel : " + sal[di.Count - 1]);
                Console.WriteLine("----------------------------------------");
                foreach (KeyValuePair<int, Employees> i in di)
                {
                    if (i.Value.EmpSal == sal[di.Count - 1])
                        Console.WriteLine(i.Key + " : " + i.Value.EmpId + "  " + "  " + i.Value.EmpName + "  " + i.Value.EmpSal);
                }



            }
            public static void empSearch(Dictionary<int, Employees> di)
            {
                Console.Write("Enter the Employee Number to search : ");
                int id = Convert.ToInt32(Console.ReadLine());

                foreach (KeyValuePair<int, Employees> i in di)
                {
                    if (id == i.Value.EmpId)
                        Console.WriteLine(i.Key + " : " + i.Value.EmpId + "  " + "  " + i.Value.EmpName + "  " + i.Value.EmpSal);
                    else
                        Console.WriteLine("Please Enter the valid Id");

                }
            }

        }
    }
}
