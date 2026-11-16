using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced.Events
{
    internal class Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public void ReceiveSalary(string message)
        {
            Console.WriteLine($"{Name}: {message}");
            Console.WriteLine($"Salary: {Salary}");
        }
    }
}