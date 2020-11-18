using System;

namespace LearnDelegate
{ 
    // C#中的Delegate https://www.cnblogs.com/hyddd/archive/2009/07/26/1531538.html
    class Program
    {
        static void OtherClassMethod(){
            Console.WriteLine("Delegate an other class's method");
        }

        static void Main(string[] args)
        {
            var test = new TestDelegate();
            test.delegateMethod = new TestDelegate.DelegateMethod(test.NonStaticMethod);
            test.delegateMethod += new TestDelegate.DelegateMethod(TestDelegate.StaticMethod);
            test.delegateMethod += Program.OtherClassMethod;
            test.RunDelegateMethods();
        }
    }

    class TestDelegate
    {
        public delegate void DelegateMethod();  //声明了一个Delegate Type

        public DelegateMethod delegateMethod;   //声明了一个Delegate对象

        public static void StaticMethod()   
        {
            Console.WriteLine("Delegate a static method");
        }

        public void NonStaticMethod()   
        {
            Console.WriteLine("Delegate a non-static method");
        }

        public void RunDelegateMethods()
        {
            if(delegateMethod != null){
                Console.WriteLine("---------");
                
                delegateMethod();
                //what's the difference between up and down？  most of cases, they are same
                delegateMethod.Invoke();    
                Console.WriteLine("---------");
            }
        }
    }
}