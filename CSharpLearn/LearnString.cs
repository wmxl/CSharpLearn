using System;
using System.Reflection;
using System.Text;

namespace CSharpLearn
{
    public class LearnString
    {
        static void Main(string[] args)
        {
            // StringEquals_InvariantCultureIgnoreCase();
            // LearnStringBuilder();
            LearnDefautType();
        }

        static void StringEquals_InvariantCultureIgnoreCase()
        {
            const string originalString = "Original String";
            const string inDifferentCase = "oRiginal String";

            // change the variable values in the following 2 lines.
            bool shouldBeFalse = originalString.Equals(inDifferentCase, StringComparison.InvariantCulture);
            bool shouldBeTrue = originalString.Equals(inDifferentCase, StringComparison.InvariantCultureIgnoreCase);

            Console.WriteLine(shouldBeFalse);
            Console.WriteLine(shouldBeTrue);
        }

        static void LearnStringBuilder()
        {
            StringBuilder sb = new StringBuilder("abcdefghijk", 3);
            Console.WriteLine(sb);
            Console.WriteLine(sb.ToString());
        }
        
        static void LearnDefautType()
        {
            Console.WriteLine(default(int));
            Console.WriteLine(default(bool));
            Console.WriteLine(default(char));
            Console.WriteLine(default(object));
            Console.WriteLine(default(string));
        }
    }
}