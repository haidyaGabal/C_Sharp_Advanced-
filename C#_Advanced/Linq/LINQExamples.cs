
using System;
using System.Collections.Generic;
using System.Linq;

namespace C__Advanced.Linq
{
    public class LINQExamples
    {
        #region Integer Example

        public void IntExample()
        {
            List<int> numbers = new List<int>
            {
                1, 3, 5, 7, 8, 10, 12, 15, 20
            };

            // Quary syntax
            //numbers => data source
            //where => filter remember (where is generic funk)
            //select => projection select num of data
            var querySyntax =
                from number in numbers
                where number > 5
                select number;

            Console.WriteLine("=== Query Syntax ===");

            foreach (var number in querySyntax)
            {
                Console.WriteLine(number);
            }

            // Method Syntax (Lambda Expression)
            var methodSyntax = numbers.Where(number => number > 5);
            Console.WriteLine("\n=== Method Syntax ===");

            foreach (var number in methodSyntax)
            {
                Console.WriteLine(number);
            }
        }

        #endregion

        #region String Example

        public void StringExample()
        {
            List<string> names = new List<string>
            {
                "Ahmed", "Haidy", "Ali", "Mohamed", "Amr"
            };

            // Get names starting with A
            var result = names.Where(name => name.StartsWith("A"));

            Console.WriteLine("=== Names Starting With A ===");

            foreach (var name in result)
            {
                Console.WriteLine(name);
            }
        }

        #endregion

        #region Object Example

        public void ObjectExample()
        {
            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "Ahmed", Age = 20, Grade = 85 },
                new Student { Id = 2, Name = "Ali", Age = 22, Grade = 90 },
                new Student { Id = 3, Name = "Sara", Age = 19, Grade = 75 },
                new Student { Id = 4, Name = "Mona", Age = 21, Grade = 95 }
            };

            // Get students with grades greater than 80
            var result = students.Where(student => student.Grade > 80);

            Console.WriteLine("=== Students With Grades Above 80 ===");

            foreach (var student in result)
            {
                Console.WriteLine(
                    $"Name: {student.Name}, Grade: {student.Grade}"
                );
            }
        }

        #endregion
    }
}
