﻿using System;
using System.IO;

namespace LearnUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            string manyLines=@"This is line one
                            This is line two
                            Here is line three
                            The penultimate line is line four
                            This is the final, fifth line.";

            var reader = new StringReader(manyLines);
            
                string? item;
                do {
                    item = reader.ReadLine();
                    Console.WriteLine(item);
                } while(item != null);
            
        }
    }
}