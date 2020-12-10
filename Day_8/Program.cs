using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8
{
    class Program
    {
        static void Main1(string[] args)
        {
            Func<decimal, decimal, decimal, decimal> simpleInterest = (decimal p, decimal n, decimal r) => { return (p * n * r) / 100; };
            Console.WriteLine("Simple Interest : " + simpleInterest(1000, 2, 10));
            Console.ReadLine();
        }
        static void Main2()
        {
            Func<int, int, bool> isGreater = (int a, int b) => { return a > b; };
            Console.WriteLine("a & b Greater is : " + isGreater(10, 20));
            Console.ReadLine();
        }

        static void Main3()
        {
            Employee obj = new Employee();
            Func<decimal, Employee> emp = (decimal sal) => { obj.Sal = sal; return obj; };
            Employee o = emp(1111);
            Console.WriteLine("Basic sal is : " + o.Sal);
            Console.ReadLine();

        }
        static void Main4()
        {
            Predicate<int> isEven = (int num) => { return num % 2 == 0; };
            Console.WriteLine("Check Is Even : " + isEven(100));
            Console.ReadLine();
        }
        static void Main()
        {
            Predicate<Employee> isGreaterThan10000 = (Employee e) => { return e.Sal > 1000; };
            Employee emp = new Employee();
            emp.Sal = 2000;
            Console.WriteLine("IsGreaterThan10000 : " + isGreaterThan10000(emp));
            Console.ReadLine();
        }

    }
    public class Employee
    {
        private decimal sal;
        public decimal Sal { get; set; }
    }
}
