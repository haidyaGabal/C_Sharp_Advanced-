using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace C__Advanced.Events
{
    public delegate void PaidSalary(string message);

    public class CalculateSalary
    {
        public event PaidSalary SalaryCompleted;

        public void CreateSalarySheet()
        {
            Console.WriteLine("Creating salary sheet...");

            OnSalaryCompleted();
        }

        protected virtual void OnSalaryCompleted()
        {
            SalaryCompleted?.Invoke("Your salary has been paid!");
        }
    }
}