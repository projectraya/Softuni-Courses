using System;

namespace Review_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sandbox sandbox = new Sandbox();
            sandbox.Size = 5; //this is possible because of set, it sets the value
            int takeSize = sandbox.Size; //this is possible because of get, it gets and returns the value

            Sandbox advanced = new Sandbox(7);
            
        }
    }
}
