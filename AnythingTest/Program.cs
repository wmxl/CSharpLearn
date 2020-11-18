using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.VisualBasic.CompilerServices;

namespace AnythingTest
{
    
    class Program
    {
        public static Func<int, bool> IsProcessedInBill()
        {
            return billingInfo => billingInfo > 0;
        }
        public static Expression<Func<int, bool>> IsProcessedInBill1()
        {
            return billingInfo => billingInfo > 0;
        }

        static void Main(string[] args)
        {
            Func<int,bool> func1 = Program.IsProcessedInBill();
            Console.WriteLine(func1(-1));
            Console.WriteLine(func1(1));

            var e = Program.IsProcessedInBill1();
            Console.WriteLine("e.Name: "+ e.Name);
            Console.WriteLine("Body:" + e.Body);
            Console.WriteLine("Parameters: "+ e.Parameters);
            Console.WriteLine("Type: "+ e.Type);
            Console.WriteLine("e.Compile():"+ e.Compile());
        }
    }
}