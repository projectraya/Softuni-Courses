using System;

namespace whileloop
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int total = 0;
            
            
            while(input != "end")
            {
                int currentNum = int.Parse(input); // parsevane e versiqta na input kato chislo zashtoto inache e text kogato go vuvejdame
                total += currentNum;
                if(total > 20)
                {
                    break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(total);
;
        }
    }
}
