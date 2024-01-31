using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Avidence13
{
    internal class Person
    {
        string name; int age;
        static int totalCount = 0;
        public string _Name { get { return name; } set { name = value; } }
        public int _Age { get { return age; } set { age = value; } }


        //public Person()
        //{
        //    ++totalCount;
        //}
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            totalCount++;
        }
        public virtual void PrintDetails()
        {
            Console.WriteLine($"Person Name: {name}, age: {age}");
        }

        public  void  PrintDetails( string customMsg)
        {
            Console.WriteLine($"Person Name: {name}, age: {age}, Custom Message: {customMsg}");
        }
        public Person(string name = "No Name")
        {
            this.name=name;
        }
        public Person(int age = 0)
        {
            this.age=age;
        }
        
        public string SetName(string newName)
        {
            if (newName == null || newName =="" )
            {
                throw new ArgumentNullException("name can't be null");
            }
            else
            {
                return this.name = newName;
            }
        }

        static void Main()
        {
            Person p1 = new Person("Mehedi Hasan", 22);
            p1.PrintDetails();
            Person p2 = new Person("Al-Amin", 29);
            p2.PrintDetails("All the best!");
            p2.SetName("Rabbi");
            p2.PrintDetails();
            p2.PrintDetails("All the best!");

            Console.WriteLine($"Number of object Created: {totalCount}");

            Person[] person = { p1, p2 };
            foreach (Person obj in person)
            {
                obj.PrintDetails() ;
            }

            Console.ReadKey();
        }

    }
    
}
