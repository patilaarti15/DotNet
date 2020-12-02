using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Employee o1 = new Employee("Aarti", 112233, 30);
            Employee o2 = new Employee("Aarti", 112233);
            Employee o3 = new Employee("Aarti");
            Employee o4 = new Employee();

            Console.WriteLine(o1.getNetSalary());

            Console.WriteLine(o1.EmpNo);
            Console.WriteLine(o2.EmpNo);
            Console.WriteLine(o3.EmpNo);

            Console.WriteLine(o3.EmpNo);
            Console.WriteLine(o2.EmpNo);
            Console.WriteLine(o1.EmpNo);

            Console.ReadLine();
        }
    }
    class Employee
    {
        private string empName;
        private decimal basicSalary;
        private short deptNo;
        static int id = 0;
        static Employee()
        {

        }
       
        public Employee()
        {

        }
        public Employee(string empName, decimal basicSalary, short deptNo)
        {
            id++;
            this.EmpNo = id;
            this.EmpName = empName;
            this.BasicSalary = basicSalary;
            this.DeptNo = deptNo;
        }
        public Employee(string empName, decimal basicSalary)
        {
            id++;
            this.EmpNo = id;
            this.EmpName = empName;
            this.BasicSalary = basicSalary;

        }

        public Employee(string empName)
        {
            id++;
            this.EmpNo = id;
            this.EmpName = empName;
        }


        public string EmpName
        {
            get { return empName; }
            set
            {
                if (value == null)
                {
                    empName = value;
                }
                else
                    Console.WriteLine("Invalid Name !!");
            }
        }
        public int EmpNo
        {
            get;
        }

        public decimal BasicSalary
        {
            get { return basicSalary; }
            set
            {
                if (value > 1000 && value < 1000000)
                    basicSalary = value;
                else
                    Console.WriteLine("Invalid salary !!");
            }
        }
        public short DeptNo
        {
            get { return deptNo; }
            set
            {
                if (value > 0)
                    deptNo = value;
                else
                    Console.WriteLine("Invalid Depatment Number !!");
            }
        }

        public decimal getNetSalary()
        {
            double deduction = 1000;
            decimal salary = basicSalary - (decimal)deduction;
            return salary;
        }
    }
}
