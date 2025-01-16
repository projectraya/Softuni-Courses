using BorderControl;

namespace BirthdayCelebrations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            List<Entities> entities = new List<Entities>();


            while (input[0] != "End")
            {
                if (input[0] == "Pet")
                {
                    Pet pet = new Pet();
                    pet.BirthDate = input[2];
                    entities.Add(pet);
                }
                else if (input.Length == 5)
                {
                    Citizen citizen = new Citizen();
                    citizen.BirthDate = input[4];
                    entities.Add(citizen);
                }

                input = Console.ReadLine().Split().ToArray();
            }

            string endNumber = Console.ReadLine();



            foreach (Entities entity in entities)
            {
                if (entity.BirthDate.EndsWith(endNumber))
                {
                    Console.WriteLine(entity.BirthDate);
                }

            }
        }
    }
}
