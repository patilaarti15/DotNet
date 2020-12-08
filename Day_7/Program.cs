using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentEvent06
{
    class EventAssignment
    {
        static void Main(string[] args)
        {
            List<Employees> li = new List<Employees>();

            try
            {
                char choice = 'y';
                while (choice == 'y')
                {
                    Employees.insertEmployee(li);
                    Console.Write("Do you Want to continue type (y/n) : ");
                    choice = Convert.ToChar(Console.ReadLine());

                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Please Enter Valid Input");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



            Employees[] arr = li.ToArray();

            foreach (Employees el in arr)
            {
                Console.WriteLine(el.EmpId + "  " + el.EmpName + "  " + el.EmpSal);
            }


            Console.ReadLine();
        }
    }
    public delegate void InvalidEmpIdEvenHandler();
    public delegate void InvalidEmpNameEvenHandler();
    public delegate void InvalidEmpSalEvenHandler();
    class Employees
    {
        public event InvalidEmpIdEvenHandler invalidEmpId;
        public event InvalidEmpNameEvenHandler invalidEmpName;
        public event InvalidEmpSalEvenHandler invalidEmpSal;

        private int empId;

        private string empName;
        private decimal empSal;

        public int EmpId
        {
            get { return empId; }
            set
            {
                if (value < 10) empId = value;
                else
                {
                    invalidEmpId();
                }
            }
        }
        public string EmpName
        {
            get { return empName; }
            set
            {
                if (value == null)
                {
                    invalidEmpName();
                }
                else empName = value;
            }
        }
        public decimal EmpSal
        {
            get { return empSal; }
            set
            {
                if (value < 1000)
                {
                    invalidEmpSal();
                }
                else empSal = value;
            }
        }

        public Employees(int empId, string empName, decimal empSal)
        {
            this.EmpId = empId;
            this.EmpName = empName;
            this.EmpSal = empSal;
        }
        public Employees()
        {

        }
        public static void insertEmployee(List<Employees> li)
        {
            Employees emp = new Employees();
            emp.invalidEmpId += Emp_invalidEmpId;
            emp.invalidEmpName += Emp_invalidEmpName;
            emp.invalidEmpSal += Emp_invalidEmpSal;
            Console.WriteLine("-------------------------------------------------");
            Console.Write("Enter Employee Id : ");
            int empId = Convert.ToInt32(Console.ReadLine());
            emp.EmpId = empId;
            Console.Write("Enter Employee Name : ");
            string empName = Console.ReadLine();
            emp.EmpName = empName;
            Console.Write("Enter Employee Sal : ");
            decimal empSal = Convert.ToDecimal(Console.ReadLine());
            emp.EmpSal = empSal;
            li.Add(new Employees(empId, empName, empSal));
            //li.Add(new Employees { EmpId = empId, EmpName = empName, EmpSal = empSal });
        }

        private static void Emp_invalidEmpSal()
        {
            Console.WriteLine("Sal should be Greater then 1000 !!");
        }

        private static void Emp_invalidEmpName()
        {
            Console.WriteLine("Name should not be Null !!");
        }

        private static void Emp_invalidEmpId()
        {
            Console.WriteLine("Emp Id should be Less then 10 !!");
        }
    }

}

