using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses_Exercises
{
    public class DateCounter
    {
        public int Calculate(string date1, string date2)
        {
            int[] firstDate = date1.Split("/").Select(int.Parse).ToArray();
            int[] secondDate = date2.Split("/").Select(int.Parse).ToArray();

            DateTime first = new DateTime(firstDate[0], firstDate[1], firstDate[2]);
            DateTime second = new DateTime(secondDate[0], secondDate[1], secondDate[2]);


            int days = Math.Abs((first - second).Days);
            return days;

        }
    }
}
