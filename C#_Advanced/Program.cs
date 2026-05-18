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
            //  DelegatesMethod();


            ///3- MultithreadingBasics
          
            var b1 = new Thread(MultithreadingBasics.ProcessBatch1);
            b1.Priority=ThreadPriority.Highest;
            var b2 = new Thread(MultithreadingBasics.ProcessBatch2);
            b2.Priority=ThreadPriority.Lowest;
            b1.Start();
            b2.Start();
            ///can add priority for this thread
         






        }
    }
}
