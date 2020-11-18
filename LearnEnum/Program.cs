using System;

namespace LearnEnum
{ 
    enum BorderSideFlag
    {
        Left = 1,      //0001
        Right = 2,     //0010
        Top = 4,       //0100
        Bottom = 8,    //1000
        LeftAndRight = Left | Right,
        TopAndBottom = Top | Bottom,
        All = Left | Right | Top | Bottom
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BorderSideFlag.Left); //Left
            Console.WriteLine((int)BorderSideFlag.Left); //1
            Console.WriteLine((int)Enum.Parse(typeof(BorderSideFlag), "Left")); //1
            Console.WriteLine(Enum.Parse(typeof(BorderSideFlag), "1")); //Left
            Console.WriteLine(BorderSideFlag.Right);
            Console.WriteLine(BorderSideFlag.Top);
            Console.WriteLine(BorderSideFlag.Bottom);
            Console.WriteLine((int)BorderSideFlag.LeftAndRight); //3
            Console.WriteLine((int)BorderSideFlag.TopAndBottom); //12
            Console.WriteLine((int)BorderSideFlag.All); //15

           
        }
    }
}