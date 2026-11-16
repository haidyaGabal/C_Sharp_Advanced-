using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace C__Advanced.Extesion_Methods
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public void Create()
        {
            Console.WriteLine($"Employee {Name} created successfully.");
        }
    }
}