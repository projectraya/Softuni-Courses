namespace Abstraction_Sandbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string species = "Colibri";
            int friends = 3;
            bool canFly = true;

            Bird bird = new Bird(species, friends, canFly);

            bird.Walk();
            bird.Run();
        }
    }
}
