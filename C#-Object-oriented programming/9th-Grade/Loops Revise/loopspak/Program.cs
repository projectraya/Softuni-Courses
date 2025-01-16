using System;

namespace loopspak
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            int budget = int.Parse(Console.ReadLine());
            
            int sum = 0;
            bool isEnd = false;

            while(isEnd == false)
            {
                for(int i = sum; i < budget; i++)
                {
                
                  int amount = int.Parse(Console.ReadLine());
                  sum += amount;
                  if(sum >= budget)
                  {
                     Console.WriteLine($"Going to {destination}!");
                     sum = 0;
                     destination = Console.ReadLine();
                     budget = int.Parse(Console.ReadLine());
                     if(destination == "End")
                     {
                            isEnd = true;
                            break;

                     }
                        
                  }
                    
                }
               
            }
            if (isEnd)
            {
                return;

            }
             
         
        }
    }
}
