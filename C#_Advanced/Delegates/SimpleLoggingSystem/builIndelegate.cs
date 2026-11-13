using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced.Delegates.SimpleLoggingSystem
{
    internal class builIndelegate
    {
        public void simple()
        {
            // 1. Action: Display a message
            Console.WriteLine("=== Action ===");

            Action<string> displayMessage = message =>
            {
                Console.WriteLine(message);
            };

            displayMessage("Welcome to C# Delegates!");


            // 2. Func: Calculate sum
            Console.WriteLine("\n=== Func ===");

            Func<int, int, int> calculateSum = (x, y) => x + y;

            int result = calculateSum(10, 20);

            Console.WriteLine($"Sum = {result}");


            // 3. Predicate: Check even numbers
            Console.WriteLine("\n=== Predicate ===");

            Predicate<int> isEven = number => number % 2 == 0;
           

            int[] numbers = { 1, 2, 3, 4, 5, 6 };

            foreach (int number in numbers)
            {
                if (isEven(number))
                {
                    Console.WriteLine($"{number} is Even");
                }
            }
        }
    }
}

