
using C__Advanced.Delegates.BasicNotificationSystem;
using C__Advanced.Delegates.FilterAndTransformNumbers;
using C__Advanced.Delegates.SimpleLoggingSystem;
using C__Advanced.Events;
using C__Advanced.Events.EventTimer;
using C__Advanced.Extesion_Methods;
using C__Advanced.Linq;
using System.Text.Json;

namespace C__Advanced
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // 1. Extension Methods
            // Extension_Method();

            // 2. Delegates
            // DelegatesMethod();

            // 3. Notification System
            // SimpleNotification();

            // 4. Filter And Transform
            // FilterAndTransform();

            // 5. Built-in Delegates
            // BuiltInDelegates();

            // 6. Events
            // Events();
            //7.Timer Ex
            // TimerEx();
            //8.Extinsion Methods
            //ExMethods();
            //9.1.LINQ Exampls
            // LINQEX();
            //9.2.LoadData
           // LoadData();

            // 10. Multithreading Basics
            // Multithreading();

            // 11. Task-Based Asynchronous Programming
            // await Task_Based();
        }

        #region Extension Methods

        static void Extension_Method()
        {
            int number = 14;

            if (number.checkNumberBetween(10, 40))
                Console.WriteLine("Is Between");
            else
                Console.WriteLine("Is Not");
        }

        #endregion

        #region Delegates

        static void DelegatesMethod()
        {
            Delegates.Delegates delegates =
                new Delegates.Delegates(20, 10);
        }

        #endregion

        #region Notification System

        static void SimpleNotification()
        {
            EmailNotifications email = new EmailNotifications();
            SMSNotification sms = new SMSNotification();

            Notify notifier = email.Send;
            notifier += sms.Send;

            Order order = new Order(notifier);

            // order.CreateOrder();
        }

        #endregion

        #region Filter And Transform

        static void FilterAndTransform()
        {
            int[] numbers = { 2, 5, 8, 12, 15, 20 };

            Filter filter = new Filter();

            Console.WriteLine("=== Filter Numbers ===");

            foreach (int number in numbers)
            {
                if (filter.FilterMethod(number))
                    Console.WriteLine(number);
            }

            // Change filter method
            filter.FilterMethod = filter.GreaterThan10;

            Console.WriteLine("\n=== Numbers Greater Than 10 ===");

            foreach (int number in numbers)
            {
                if (filter.FilterMethod(number))
                    Console.WriteLine(number);
            }

            Transform transform = new Transform();

            Console.WriteLine("\n=== Double Numbers ===");

            foreach (int number in numbers)
            {
                Console.WriteLine(transform.TransformMethod(number));
            }

            // Change transformation method
            transform.TransformMethod = transform.SquareNumber;

            Console.WriteLine("\n=== Square Numbers ===");

            foreach (int number in numbers)
            {
                Console.WriteLine(transform.TransformMethod(number));
            }
        }

        #endregion

        #region Built-in Delegates

        static void BuiltInDelegates()
        {
            builIndelegate indelegate = new builIndelegate();
            // indelegate.simple();
        }

        #endregion

        #region Events

        static void Events()
        {
            CalculateSalary calculateSalary = new CalculateSalary();

            Employees emp1 = new Employees
            {
                Id = 1,
                Name = "Ahmed",
                Salary = 10000
            };

            Employees emp2 = new Employees
            {
                Id = 2,
                Name = "Ali",
                Salary = 12000
            };

            // Subscribe employees to the event
            calculateSalary.SalaryCompleted += emp1.ReceiveSalary;
            calculateSalary.SalaryCompleted += emp2.ReceiveSalary;

            // Raise the event
            calculateSalary.CreateSalarySheet();

            // Unsubscribe employees
            calculateSalary.SalaryCompleted -= emp1.ReceiveSalary;
            calculateSalary.SalaryCompleted -= emp2.ReceiveSalary;
        }

        #endregion

        #region Timer Event Ex
        static void TimerEx()
        {
            LegedTimer timer = new LegedTimer(5);

            timer.TickAction += remaining =>
                Console.WriteLine($"Remaining: {remaining} seconds");

            timer.TimerEnded += () =>
                Console.WriteLine("Timer finished!");

            timer.Start();
        }


        #endregion

        #region Extentsion Methods
       static void ExMethods()
        {
            ///string Ex
            string text = "Welcome to C Sharp Advanced";
            int count = text.NumberOfWords();
            Console.WriteLine(count);

            ///int Ex
            int number = 10;
            Console.WriteLine(number.ISEven()); // True
            Console.WriteLine(7.ISEven());      // False

            ///class Ex
            Employee employee = new Employee
            {
                Id = 1,
                Name = "Ahmed",
                Description = "Junior .NET Developer"
            };

            employee.Create();
            employee.Hire();
        }
        #endregion

        #region LINQ Examples

        static void LINQEX()
        {
            LINQExamples linq = new LINQExamples();

            linq.IntExample();
             linq.StringExample();
             linq.ObjectExample();

        }
        static void LoadData()
        {
            DealingWithLINQ dealing = new DealingWithLINQ();

            //  dealing.FirstExample();
            //  dealing.LastExample();
            //  dealing.WhereCondition();
            //  dealing.Sorting();
            //  dealing.Projection();
            dealing.Aggregation();

        }
        #endregion

        #region Multithreading

        static void Multithreading()
        {
            Thread b1 = new Thread(MultithreadingBasics.ProcessBatch1)
            {
                Priority = ThreadPriority.Highest
            };

            Thread b2 = new Thread(MultithreadingBasics.ProcessBatch2)
            {
                Priority = ThreadPriority.Lowest
            };

            // b1.Start();
            // b2.Start();
        }

        #endregion

        #region Task-Based Asynchronous Programming

        static async Task Task_Based()
        {
            Task_BasedAsynchronousPattern tap =
                new Task_BasedAsynchronousPattern();

            IProgress<int> progress = new Progress<int>(value =>
            {
                Console.WriteLine($"Progress: {value}%");
            });

            await tap.DownloadAsync(progress);

            Console.WriteLine("Download completed!");
        }

        #endregion
    }
}
