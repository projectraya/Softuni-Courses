namespace CustomStack
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings stackOne = new StackOfStrings();

            Console.WriteLine(stackOne.IsEmpty()); //True

            Stack<string> fullStack = new Stack<string>();

            fullStack.Push("b");
            fullStack.Push("c");

            stackOne.AddRange(fullStack);

            Console.WriteLine(stackOne.IsEmpty()); //False
        }
    }
}
