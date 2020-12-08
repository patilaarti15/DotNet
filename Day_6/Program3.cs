using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment05
{
    class Que3
    {
        public static void Main()
        {
            Employees1[] empArr = new Employees1[3];

            for (int i = 0; i < empArr.Length; i++)
            {
                Console.WriteLine("-------------------------------------------------");
                Console.Write("Enter Employee Id : ");
                int empId = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Employee Name : ");
                string empName = Console.ReadLine();
                Console.Write("Enter Employee Sal : ");
                decimal empSal = Convert.ToDecimal(Console.ReadLine());

                empArr[i] = new Employees1(empId, empName, empSal);
            }

            List<Employees1> li = empArr.OfType<Employees1>().ToList();

            foreach (Employees1 el in li)
            {
                Console.WriteLine(el.EmpId + "  " + el.EmpName + "   " + el.EmpSal);
            }


            Console.ReadLine();
        }


    }

    class Employees1
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

        public Employees1(int empId = 143, string empName = "Jadu", decimal empSal = 10001)
        {
            this.EmpId = empId;
            this.EmpName = empName;
            this.EmpSal = empSal;
        }
    }




}