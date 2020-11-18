using System;
using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;

namespace AnythingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var functionList = new List<Func<int>>();

            int num;
            for (int i = 0; i < 3; ++i)
            {
                num = i;
                functionList.Add(() => num);
                Console.WriteLine(functionList[i]());
            }
            for (int i = 0; i < 3; ++i)
            {
                Console.WriteLine(functionList[i]());
            }

            Console.WriteLine("-------");

            int sum = 0;
            foreach (Func<int> func in functionList)
            {
                Console.WriteLine(func());
                sum += func();
            }
            Console.WriteLine("sum:" + sum);
        }
    }
}