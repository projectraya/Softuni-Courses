using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
    public class StationaryPhone : Phones, ICallable
    {
        public void PrintCalledNumber(string number)
        {
            if (IsValidNumber(number))
            {
                Console.WriteLine("Dialing... " + number);
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }

        }
    }
}
