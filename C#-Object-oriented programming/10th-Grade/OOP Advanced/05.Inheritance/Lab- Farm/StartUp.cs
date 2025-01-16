namespace Farm
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Dog dog = new Dog();
            Cat puppy = new Cat();
            dog.Eat();
            dog.Bark();

            puppy.Eat();
            puppy.Meow();

        }
    }
}
