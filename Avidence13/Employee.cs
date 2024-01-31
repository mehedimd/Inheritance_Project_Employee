using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Avidence13
{
    internal class Employee : Person
    {
        double salary;
        public double _Salary { get { return salary; } set { salary = value; } }
        public Employee(double salary, string nm, int ag): base(name: nm, age: ag)
        {
            this.salary = salary;
            
        }

        public void PrintEmployeeDetails()
        {
            Console.WriteLine($"Person Name: {_Name}, age: {_Age}, salary: {_Salary}"); 
        }
        public override void PrintDetails()
        {
            Console.WriteLine($"Person Name: {_Name}, age: {_Age}, salary: {_Salary}");
        }

        static void Main()
        {
            Employee e = new Employee(2500,"mehu", 26);
            e.PrintEmployeeDetails();
            e.PrintDetails();

            Console.ReadKey();
        }
    }
}
