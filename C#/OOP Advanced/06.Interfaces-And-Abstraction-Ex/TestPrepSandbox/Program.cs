namespace TestPrepSandbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBinaryFile file = new FileInfo();
            file.OpenBinaryFile();
            file.ReadFile();


           // FileBase base = new FileBase(); //cant because it's abstract
        }
    }
}
