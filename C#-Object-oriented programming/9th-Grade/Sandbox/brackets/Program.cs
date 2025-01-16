using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace mrsimonachin
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("input.txt"))

            {

                string line = reader.ReadLine();

                int counter = 1;

                using (var writer = new StreamWriter("output.txt"))

                    while (line != null)

                    {

                        writer.WriteLine($"{counter}. {line}");

                        line = reader.ReadLine();

                        counter++;

                    }

            }


        }
    }
}
