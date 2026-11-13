using System;

namespace C__Advanced.Delegates
{
    public class Delegates
    {
        #region Delegate Declaration

        /// <summary>
        /// A delegate defines the signature of methods it can reference.
        /// The return type and parameters must match.
        /// </summary>
        private delegate int CalculateDelegate(int x, int y);

        #endregion

        #region Constructor

        public Delegates(int x, int y)
        {
            Console.WriteLine("=== Named Methods ===");

            Calculate(x, y, Add);
            Calculate(x, y, Subtract);
            Calculate(x, y, Divide);
            Calculate(x, y, Multiply);

            Console.WriteLine("\n=== Delegate Variable ===");

            CalculateDelegate calculateDelegate = Add;
            Calculate(x, y, calculateDelegate);

            calculateDelegate = Subtract;
            Calculate(x, y, calculateDelegate);

            Console.WriteLine("\n=== Anonymous Method ===");

            Calculate(x, y, delegate (int a, int b)
            {
                return a / b;
            });

            Console.WriteLine("\n=== Lambda Expression ===");

            Calculate(x, y, (a, b) => a / b);

            Console.WriteLine("\n=== Multicast Delegate ===");

            MultiCastOfDelegate(x, y);
        }

        #endregion

        #region Delegate Methods

        /// <summary>
        /// Executes the method referenced by the delegate.
        /// </summary>
        private void Calculate(int x, int y, CalculateDelegate calculateDelegate)
        {
            int result = calculateDelegate(x, y);

            Console.WriteLine($"Result: {result}");
        }

        /// <summary>
        /// Demonstrates a multicast delegate.
        /// Multiple methods are attached to one delegate.
        /// </summary>
        private void MultiCastOfDelegate(int x, int y)
        {
            CalculateDelegate calculateDelegate = Add;

            calculateDelegate += Subtract;

            // Both methods execute, but only the last return value is kept.
            Calculate(x, y, calculateDelegate);
        }

        #endregion

        #region Arithmetic Operations

        private int Add(int x, int y)
        {
            Console.WriteLine("Add");
            return x + y;
        }

        private int Subtract(int x, int y)
        {
            Console.WriteLine("Subtract");
            return x - y;
        }

        private int Divide(int x, int y)
        {
            Console.WriteLine("Divide");
            return x / y;
        }

        private int Multiply(int x, int y)
        {
            Console.WriteLine("Multiply");
            return x * y;
        }

        #endregion
    }
}
