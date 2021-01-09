using System;
using Microsoft.VisualBasic.CompilerServices;

namespace TypeCheckingSummary
{
    class Animal { } 
    class Dog : Animal { }
    
    class Program
    {
        static void TypeTest(Animal a) { 
            Console.WriteLine(a.GetType() == typeof(Animal));
            Console.WriteLine(a.GetType() == typeof(Dog));
            Console.WriteLine(a is Animal);
            Console.WriteLine(a is Dog);
            
            // Console.WriteLine(a as Dog);
            // //same as
            // Console.WriteLine(a is Dog? (Dog)a : null);
            // Console.WriteLine();
            // //Notes: as can only be used on with reference types  a as int  is wrong 
       }

        static string GetType<T>(T parameter)
        {
            return typeof(T).Name;
        }
        
        static void Main(string[] args)
        {
            Animal spot = new Dog();
            TypeTest(spot);

            // Animal animalDog = new Dog();
            // Dog dog = new Dog();
            //
            // Console.WriteLine(GetType(animalDog));
            // Console.WriteLine(GetType(dog));
            // Console.WriteLine(GetType<Animal>(dog));
            // Console.WriteLine(GetType((Animal) dog));
        }
    }
}


