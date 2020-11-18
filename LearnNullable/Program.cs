using System;

namespace LearnNullable
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> nullableInt = null;
            Nullable<int> num = 1;
            Console.WriteLine(nullableInt);
            Console.WriteLine(num);
        }
    }
}