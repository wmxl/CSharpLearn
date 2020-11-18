using System;

public class RefTypeClass
{
    public RefTypeClass(int value)
    {
        Value = value;
    }

    public int Value { get; set; } 
}

namespace LearnPassbyRef
{
    class Program
    {
        static void Main(string[] args)
        {
            // var refTypeObject = new RefTypeClass(2);
            // RefTypeClass newOne =  FunctionPassingRefRefTypeClassAsArgument(
            //     ref refTypeObject);
            //
            // Console.WriteLine(refTypeObject.Value);
            // Console.WriteLine(refTypeObject == newOne);
            
            var refTypeObject = new RefTypeClass(1);
            RefTypeClass refToOriginalObject = refTypeObject;

            RefTypeClass modifiedRefTypeObject = FunctionPassingRefRefTypeClassAsArgument(
                ref refTypeObject);

            // change the variable value to correct one
            RefTypeClass expectedResult = refToOriginalObject;
            Console.WriteLine(refTypeObject.Value);
            Console.WriteLine(refToOriginalObject.Value);
            Console.WriteLine(expectedResult.Value);
            Console.WriteLine(expectedResult == modifiedRefTypeObject);


        }
        
        private static RefTypeClass FunctionPassingRefRefTypeClassAsArgument(
            ref RefTypeClass refTypeObject)
        {
            refTypeObject = new RefTypeClass(3);
            return refTypeObject;
        }
    }
}