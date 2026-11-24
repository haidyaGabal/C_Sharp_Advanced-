using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced.Reflection
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public decimal CreditLimit { get; set; }
        public bool IsVerified { get; set; }

        public Customer()
        {
        }

        public Customer(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Customer Name: {Name}");
            Console.WriteLine($"Email: {Email}");
        }

        public void SendEmail(string message)
        {
            Console.WriteLine($"Sending to {Email}: {message}");
        }

        public string GetCustomerCategory()
        {
            return Age >= 18 ? "Adult" : "Minor";
        }

        private void ValidateEmail()
        {
            Console.WriteLine("Validating email...");
        }
    }
}
