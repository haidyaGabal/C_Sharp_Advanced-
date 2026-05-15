namespace C__Advanced
{
    internal class Program
    {
   
        static void Main(string[] args)
        {
            /// 1-Extension Methods
            void Extension_Method()
            {
                int number = 14;

                if (number.checkNumberBetween(10, 40))
                    Console.WriteLine("Is Between");
                else
                    Console.WriteLine("Is Not");

                ///WAY 1: Extension method syntax (what you write)
                    // bool result1 = number.CheckNumberBetween(10, 40);

                /// WAY 2: What actually happens (compiler generates this)
                    // bool result2 = ExtensionMethods.checkNumberBetween(number, 10, 40);
            }
            // Extension_Method();

            /// 2- Delegates

            void DelegatesMethod()
            {
                Delegates delegates=new Delegates(20,10);
            }
            DelegatesMethod();






        }
    }
}
