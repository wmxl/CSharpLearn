using System;
using Microsoft.VisualBasic.CompilerServices;

namespace LearnCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var originNumber = 0x1234;
            var byteNumber = (byte) originNumber;
            
            const byte expectedResult = 52;

            Console.WriteLine(byteNumber);
        }
    }
}