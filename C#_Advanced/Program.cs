namespace C__Advanced
{
    internal class Program
    {
   
        static void Main(string[] args)
        {
            /// 1-Extension Methods
            void ExtensionMethods()
            {
                int number = 14;

                if (number.checkNumberBetween(10, 40))
                    Console.WriteLine("Is Between");
                else
                    Console.WriteLine("Is Not");
            }
            // ExtensionMethods();

            /// 2- Delegates
            
            void DelegatesMethod()
            {
                Delegates delegates=new Delegates(20,10);
            }
            DelegatesMethod();






        }
    }
}
