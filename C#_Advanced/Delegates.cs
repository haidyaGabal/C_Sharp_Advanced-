using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced
{
    public class Delegates
    {
       
            
        delegate int CalculateDelegate(int x, int y);

        public Delegates(int x,int y)
        {
            Calculate(x, y,Add);
            Calculate(x, y, Subtract);
            Calculate(x, y, Divide);
            Calculate(x, y, Multiply);
        }

        void Calculate(int x, int y, CalculateDelegate dlg)
        {
            int resulte = dlg( x,  y);
            Console.WriteLine(resulte);
        }



        int Add(int x, int y)
        {
            Console.WriteLine("Add");
            return x + y;
        }
        int Subtract(int x, int y)
        {
            Console.WriteLine("Subtract");
            return x - y;
        }
        int Divide(int x, int y)
        {
            Console.WriteLine("Divide");
            return x / y;
        }
        int Multiply(int x, int y)
        {
            Console.WriteLine("Multiply");
            return x * y;
        }

    }
}
