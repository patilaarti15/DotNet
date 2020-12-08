using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment05
{
    class Que2
    {
        public static void Main2()
        {
            List<Employees> li = new List<Employees>();
            char choice = 'y';
            while (choice == 'y')
            {
                Employees.insertEmployee(li);
                Console.Write("Do you Want to continue type (y/n) : ");
                choice = Convert.ToChar(Console.ReadLine());

            }
            Employees[] arr = li.ToArray();

            foreach (Employees el in arr)
            {
                Console.WriteLine(el.EmpId + "  " + el.EmpName + "  " + el.EmpSal);
            }

            //foreach (object i in li)
            //{
            //    Console.WriteLine(((Employees)i).EmpName);
            //}


            Console.ReadLine();
        }
    }
    class Employees
    {
        private int empId;

        private string empName;
        private decimal empSal;

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

        public Employees(int empId = 143, string empName = "Jadu", decimal empSal = 10001)
        {
            this.EmpId = empId;
            this.EmpName = empName;
            this.EmpSal = empSal;
        }
        //public Employees()
        //{

        //}
        public static void insertEmployee(List<Employees> li)
        {

            Console.WriteLine("-------------------------------------------------");
            Console.Write("Enter Employee Id : ");
            int empId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee Name : ");
            string empName = Console.ReadLine();
            Console.Write("Enter Employee Sal : ");
            decimal empSal = Convert.ToDecimal(Console.ReadLine());
            li.Add(new Employees(empId, empName, empSal));
            //li.Add(new Employees { EmpId = empId, EmpName = empName, EmpSal = empSal });
        }



    }
}
