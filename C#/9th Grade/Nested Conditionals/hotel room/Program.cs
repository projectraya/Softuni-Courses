using System;

namespace hotel_room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double studio = 0.00;
            double apartment = 0.00;
            double discountS = 0.00;
            double discountA = 0.00;
           

            switch (month)
            {
                case "May":
                case "October":

                    studio = 50;
                    apartment = 65;

                    if(nights > 7 && nights <= 14)
                    {
                        discountS = studio / 100 * 5;

                    }else if(nights > 14)
                    {
                        discountS = studio / 100 * 30;
                        discountA = apartment / 100 * 10;
                    }

                    
                    Console.WriteLine($"Apartment: {((apartment - discountA) * nights):F2} lv.");
                    Console.WriteLine($"Studio: {((studio - discountS) * nights):F2} lv."); break;

                case "June":
                case "September":

                    studio = 75.2;
                    apartment = 68.7;
                    if (nights > 14)
                    {
                        discountS = studio / 100 * 20;
                        discountA = apartment / 100 * 10;

                    }
                    Console.WriteLine($"Apartment: {((apartment - discountA) * nights):F2} lv.");
                    Console.WriteLine($"Studio: {((studio - discountS) * nights):F2} lv."); break;

                case "August":
                case "July":

                    studio = 76;
                    apartment = 77;
                    if (nights > 14)
                    {
                        discountA = apartment / 100 * 10;
                    }
                    Console.WriteLine($"Apartment: {((apartment - discountA) * nights):F2} lv.");
                    Console.WriteLine($"Studio: {((studio - discountS) * nights):F2} lv."); break;
            }
        }
    }
}
