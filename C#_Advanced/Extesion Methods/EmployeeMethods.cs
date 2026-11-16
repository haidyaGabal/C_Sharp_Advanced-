using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace C__Advanced.Extesion_Methods
{
    public static class EmployeeMethods
    {
        public static void Hire(this Employee employee)
        {
            Console.WriteLine(
                $"Employee {employee.Name} has been hired successfully!"
            );
        }
    }
}