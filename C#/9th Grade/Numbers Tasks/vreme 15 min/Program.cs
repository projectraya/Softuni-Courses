using System;

namespace vreme_15_min
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int dd = 0;
            int minus = 0;
            int finalHours = hours + 1;
            if(minutes >= 45 && minutes <= 59)
            {
                hours++;


            }
            else
            {
                finalHours = hours;
            }
            if(finalHours == 24){
                    finalHours = 0;
            };
            int finalMinutes = minutes + 15;

            

           
            if(finalMinutes >= 59)
            {
                minutes = 0;
                minus = finalMinutes - 60;
                dd = minutes + minus;
                if(dd <= 9)
                {
                    Console.WriteLine(finalHours + ":" + "0" + dd);
                }
                else
                {
                    Console.WriteLine(finalHours + ":" + dd);
                }
                
            }
            else
            {
                Console.WriteLine(finalHours + ":" + finalMinutes);
            };
        }
    }
}
