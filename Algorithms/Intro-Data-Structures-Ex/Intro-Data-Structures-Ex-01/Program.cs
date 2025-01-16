using System.Collections.Specialized;
using Wintellect.PowerCollections;

namespace Intro_Data_Structures_Ex_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            OrderedMultiDictionary<DateTime, string> events = new OrderedMultiDictionary<DateTime, string>(true);


            for(int i = 0; i < n; i++)
            {
                string[] eventTokens = Console.ReadLine().Split(" | ");
                string eventName = eventTokens[0];
                DateTime eventDate = DateTime.Parse(eventTokens[1]);
                events.Add(eventDate, eventName);
                
            }

            string[] datesTokens = Console.ReadLine().Split(" | ");
            DateTime startDate = DateTime.Parse(datesTokens[0]);
            DateTime endDate = DateTime.Parse(datesTokens[1]);
            OrderedMultiDictionary<DateTime, string>.View eventsInRange = events.Range(startDate, true, endDate, true);

            foreach(KeyValuePair<DateTime, ICollection<string>> e in eventsInRange)
            {
                string date = e.Key.ToString("dd-MMM-yyyy hh:mm");
                Console.WriteLine($"{e.Value} | {date}");
            }
           
        }
    }
}
