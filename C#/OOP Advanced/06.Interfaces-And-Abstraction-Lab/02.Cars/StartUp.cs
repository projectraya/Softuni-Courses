namespace Cars
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            ICar renault = new Renault("Duster", "Grey");
            IElectricCar tesla = new Tesla("Model 3", "Red", 2);

            Console.WriteLine(renault.ToString());
            Console.WriteLine(renault.Start());
            Console.WriteLine(renault.Stop());

            Console.WriteLine(tesla.ToString());
            Console.WriteLine(tesla.Start());
            Console.WriteLine(tesla.Stop());

            
        }
    }
}
