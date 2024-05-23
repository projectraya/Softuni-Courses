using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
    public class Smartphone : Phones, ICallable, IWebBrowse
    {
        public void PrintCalledNumber(string number)
        {
            if (IsValidNumber(number))
            {
                Console.WriteLine("Calling... " + number);
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }

        }

        public void Browsing(string site)
        {
            if (IsInvalidURL(site))
            {
                Console.WriteLine("Invalid URL!");
            }
            else
            {
                Console.WriteLine("Browsing: " + site + "!");

            }
        }
        


        
    }
}
