using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Manager");
            Manager m1 = new Manager("Aarti", 11, 17000000, "CEO");
            Console.WriteLine(m1.Name + "   " + m1.basic);
            Console.WriteLine("Net sal : " + m1.CalcNetSalary());


            Console.WriteLine("=========================================");
            GeneralManager g1 = new GeneralManager("Aarti", 12, 16000000, "CEO", "GOLD");
            Console.WriteLine(g1.Name + "   " + g1.basic);
            Console.WriteLine("Net sal : " + g1.CalcNetSalary());

            Console.WriteLine("=========================================");
            CEO c1 = new CEO("Aarti", 13, 20000000);
            Console.WriteLine(c1.Name + "   " + c1.basic);
            Console.WriteLine("Net sal : " + c1.CalcNetSalary());
            Console.ReadLine();
        }
    }

    public abstract class Employee
    {
        public string name;
        public int empNo;
        public short deptNo;
        public decimal basic;
        public static int id;

        public string Name
        {
            get { return name; }
            set
            {
                if (value != "")
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Invalid");

                }
            }
        }

        public int EmpNo
        {
            get;
        }

        public short DeptNo
        {
            get { return deptNo; }
            set
            {
                if (value > 0)
                {
                    deptNo = value;
                }
                else
                {
                    Console.WriteLine("Invalid!!");
                }
            }
        }

        public decimal Basic
        {
            get { return basic; }

        }

        public Employee(string name = "Aarti", short deptNo = 2, decimal basic = 123456)
        {
            id++;
            this.EmpNo = id;
            this.name = name;
            this.deptNo = deptNo;
            this.basic = basic;
        }
        public abstract decimal CalcNetSalary();



    }

    public class Manager : Employee
    {
        public string designation;

        public Manager(string name = "Aarti", short deptNo = 2, decimal basic = 123456, string designation = "CDAC")
        {
            //empNo++;
            this.designation = designation;
        }
        public string Designation
        {
            get { return designation; }
            set
            {
                if (value != "")
                {
                    designation = value;
                }
                else
                {
                    Console.WriteLine("invalid!!");
                }
            }
        }

        public override decimal CalcNetSalary()
        {
            double Deduction = 2000;
            decimal netSal = basic - (decimal)Deduction;
            return netSal;
        }
    }

    public class GeneralManager : Manager
    {
        public string perks;

        public string Perks
        {
            get { return perks; }
        }

        public GeneralManager(string name = "Aarti", short deptNo = 2, decimal basic = 123456, string designation = "CDAC", string perks = "")
        {
            //empNo++;
            this.perks = perks;
        }
        public override decimal CalcNetSalary()
        {
            double Deduction = 2000;
            decimal netSal = basic - (decimal)Deduction;
            return netSal;
        }
    }

    public class CEO : Employee
    {
        public CEO(string name = "Aarti", short deptNo = 2, decimal basic = 123456)
        {
            //empNo++;

        }
        public sealed override decimal CalcNetSalary()
        {
            double Deduction = 2000;
            decimal netSal = basic - (decimal)Deduction;
            return netSal;

        }
    }
}
