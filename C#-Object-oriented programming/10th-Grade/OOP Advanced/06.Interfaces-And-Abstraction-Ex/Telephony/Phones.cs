using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
    public class Phones 
    {
        public bool IsValidNumber(string number)
        {
            if (number.Length == 7 || number.Length == 10)

            {
                int result = 0;

                if (int.TryParse(number, out result))
                {
                    return true;
                }

            }
            return false;
        }

        public bool IsInvalidURL(string site)
        {
            bool containsInt = site.Any(char.IsDigit);
            return containsInt;
        }
    }
}
