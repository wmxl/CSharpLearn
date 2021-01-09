using System;

namespace LearnDebug
{
    class Program
    {
        static void Function1()
        {
            Console.WriteLine("Function1...");
            Function2();
        }
        static void Function2()
        {
            Console.WriteLine("Function2...");
            Function3();
        }
        static void Function3()
        {
            Console.WriteLine("Function3...");
        }
        
        static void Function4()
        {
            Console.WriteLine("Function4...");
        }
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!2");
            Console.WriteLine("Hello World!3");
            
            Function1();
            
            Function4();
            
        }
    }
}