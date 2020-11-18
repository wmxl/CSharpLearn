using System;

namespace CSharpLearn
{
    static class LearnString
    {
        static void Main(string[] args)
        {
            const string originalString = "Original String";
            const string inDifferentCase = "oRiginal String";

            // change the variable values in the following 2 lines.
            bool shouldBeFalse = originalString.Equals(inDifferentCase, StringComparison.InvariantCulture);
            bool shouldBeTrue = originalString.Equals(inDifferentCase, StringComparison.InvariantCultureIgnoreCase);

            Console.WriteLine(shouldBeFalse);
            Console.WriteLine(shouldBeTrue);
        }
    }
}