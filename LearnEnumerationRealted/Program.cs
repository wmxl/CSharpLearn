using System;
using System.Collections.Generic;

namespace LearnEnumerationRealted
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new List<string> {"good", "morning"};
            List<string>.Enumerator enumerator = collection.GetEnumerator();

            if (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
            if (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
            if (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
            if (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }

            Console.WriteLine("end");
            
        }
    }
}