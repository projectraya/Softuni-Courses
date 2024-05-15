namespace _08.Generics_Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //make more functionable

            Tuple<string, string> tuple1 = new Tuple<string, string>();
            Tuple<string, string> tuple2 = new Tuple<string, string>();
            Tuple<string, string> tuple3 = new Tuple<string, string>();

           
            string[] nameAdress = Console.ReadLine().Split().ToArray();
            string[] nameJuice = Console.ReadLine().Split().ToArray();
            string[] intDouble = Console.ReadLine().Split().ToArray();

            string name = nameAdress[0] + " " + nameAdress[1];
            string address = nameAdress[2];
            tuple1.Item1 = name;
            tuple1.Item2 = address;


            string name1 = nameJuice[0];
            int juice = int.Parse(nameJuice[1]);
            tuple2.Item1 = name1;
            tuple2.Item2 = juice;

            int integer = int.Parse(intDouble[0]);
            double doub = double.Parse(intDouble[1]);
            tuple3.Item1 = integer;
            tuple3.Item2 = doub;
            

            tuple1.Print();
            tuple2.Print();
            tuple3.Print();
        }
    }
}
