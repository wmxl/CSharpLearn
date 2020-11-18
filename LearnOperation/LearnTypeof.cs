using System;

namespace LearnOperation
{
    class LearnTypeof
    {
        public class Animal { }

        public class Giraffe : Animal { }

        public static class TypeOfExample
        {
            public static void Main()
            {
                object b = new Giraffe();
                Console.WriteLine(b is Animal);  // output: True
                Console.WriteLine(b.GetType() == typeof(Animal));  // output: False

                Console.WriteLine(b is Giraffe);  // output: True
                Console.WriteLine(b.GetType() == typeof(Giraffe));  // output: True
                
                Console.WriteLine(typeof(string));
                Console.WriteLine(typeof(string).Name);
                Console.WriteLine(typeof(string).Namespace);
                
            }
        }
    }
}