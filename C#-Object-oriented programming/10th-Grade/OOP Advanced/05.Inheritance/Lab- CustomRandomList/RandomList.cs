using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        private string name;

        public RandomList()
        {
            this.name = "a";
        }
        public string RandomString()
        {
            string result = "gfgrfg";
            return result;
        }
    }
}
