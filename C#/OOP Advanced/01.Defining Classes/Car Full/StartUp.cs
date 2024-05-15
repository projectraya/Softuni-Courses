namespace CarManufacturer
{
    internal class StartUp
    {
        static void Main(string[] args)
        {

            Car firstCar = new Car();
            Car secondCar = new Car("A", "B", 23);
            Car thirdCar = new Car("O", "P", 22, 13, 45);

            Console.WriteLine(firstCar.WhoAmI());
            Console.WriteLine(secondCar.WhoAmI());
            Console.WriteLine(thirdCar.WhoAmI());

            Tire[] tires = new Tire[4]
            {
                new Tire(1, 4),
                new Tire(2, 3),
                new Tire(2, 0),
                new Tire(4, 5)
            };

            Engine engine = new Engine(560, 6300);
        }
    }
}
