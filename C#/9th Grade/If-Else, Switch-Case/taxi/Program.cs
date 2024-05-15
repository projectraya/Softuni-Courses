using System;

namespace taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            string time = Console.ReadLine();
            double km = double.Parse(Console.ReadLine());
            double final = 0.00;

            switch (month)
            {
                case "Jan":
                case "Feb":
                case "March":
                case "Apr":

                    if(time == "Day")
                    {
                        final = 0.81 * km;
                    }else if(time == "Night")
                    {
                        final = 1 * km;
                    } break;

                case "May":
                case "June":
                case "July":
                case "Aug":
                    
                    if (time == "Day")
                    {
                        final = 0.91 * km;
                    }
                    else if (time == "Night")
                    {
                        final = 1.05 * km;
                    }
                    break;

                case "Sept":
                case "Oct":
                case "Nov":
                case "Dec":
                    
                    if (time == "Day")
                    {
                        final = 0.85 * km;
                    }
                    else if (time == "Night")
                    {
                        final = 1.03 * km;
                    }

                    break;

            }

            Console.WriteLine($"Total cost: {final:F2}lv.");
        }
    }
}
