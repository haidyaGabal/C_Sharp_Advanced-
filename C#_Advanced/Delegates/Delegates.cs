using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced
{
    public class Delegates
    {

        /// <summary>
        /// Delegate 
        ///  signature of Delegate Must be the same  signature of methods(Add,Sub,etc)
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        delegate int CalculateDelegate(int x, int y);

        public Delegates(int x,int y)
        {

            Calculate(x, y,Add);
            Calculate(x, y, Subtract);
            Calculate(x, y, Divide);
            Calculate(x, y, Multiply);

            // CalculateDelegate dlg=new CalculateDelegate(Add);
            //Calculate(x, y,dlg);
            ///or
            //  CalculateDelegate dlg2=Add;
            //Calculate(x, y,dlg2);
            // dlg2=Subtract;

            //////////////////anonmuse Method
            // Calculate(x, y, delegate (int x, int y) { return x / y; });

            ///or
            /////////////Lampda Expration
            // Calculate(x, y, (int x, int y) => x / y);
            ///or
            //  Calculate(x, y, (x, y) => x / y);


            ////
            Console.WriteLine("MultiCast");
            MultiCastOfDelegate( x, y);
        }

        void MultiCastOfDelegate(int x, int y)
        {
            CalculateDelegate dlg2 = Add;
            dlg2 += Subtract;
            Calculate(x, y, dlg2);
            
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
