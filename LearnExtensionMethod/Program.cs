using System;

namespace LearnExtensionMethod
{
    public static class MyExtensions
    {
        public static int WordCount(this String str)
        {
            return str.Split(new char[] {' ', '.', '?'},
                StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello Extension Methods";
            int i = s.WordCount();
            // same as this
            // int i = MyExtensions.WordCount(s);
            Console.WriteLine(i);
        }
        
    }
}