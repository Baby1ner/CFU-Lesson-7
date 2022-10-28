using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFU_Lesson_7
{
    internal class Program
    {
        public class Employee
        {
            private string alias;
            private string name;

            public Employee(string name, string alias)
            {
                // Use this to qualify the members of the class
                // instead of the constructor parameters.
                this.name = name;
                this.alias = alias;
            }
            public void print()
            {
                Console.WriteLine($"{name},{alias}");
            }
        }
        static void Main(string[] args)
        {
            var ak = new Employee("aza", "baba");   
            ak.print();
            
        }
    }
}
