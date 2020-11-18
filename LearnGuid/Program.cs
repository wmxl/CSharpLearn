using System;
using System.Runtime.InteropServices;

namespace LearnGuid
{
    [Guid("9245fe4a-d402-451c-b9ed-9c1a04247482")] 
    class Program
    {
        static void Main(string[] args)
        {
            GenerateGUID();
        }

        static void GenerateGUID()
        {
            Guid g = Guid.NewGuid();
            Console.WriteLine("GUID:" + System.Guid.NewGuid().ToString());
            Console.WriteLine("GUID:" + new Guid().ToString());
            Console.WriteLine("GUID:" + g.ToString());
            Console.WriteLine("GUID:" + g.ToString());
            Console.WriteLine("GUID:" + g.ToString());
        }
    }
}