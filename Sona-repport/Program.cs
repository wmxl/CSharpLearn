using System;

namespace Sona_repport
{
    public class Parent
    {
        public Parent()
        {
            DoSomething();  // Noncompliant
        }

        public virtual void DoSomething() // can be overridden
        {
            Console.WriteLine("Parent's DoSomething");
        }
    }

    public class Child : Parent
    {
        private string foo;

        public Child(string foo) // leads to call DoSomething() in Parent constructor which triggers a NullReferenceException as foo has not yet been initialized
        {
            this.foo = foo;
        }

        public override void DoSomething()
        {
            Console.WriteLine(this.foo.Length);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Child c = new Child("aaa");
        }
    }
}