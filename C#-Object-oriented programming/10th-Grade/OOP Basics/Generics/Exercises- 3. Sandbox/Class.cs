using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _08.Generics_Exercise_1
{
    public class Class //can be static, can be normal
    {
        public static List<T> Swap<T>(List<T> list, int index1, int index2)
        { //methods need to be from type T
            T helperValue = list[index1];
            list[index1] = list[index2];
            list[index2] = helperValue;

            
            return list;

            
        }

        public static void Print<T>(List<T> list, int one, int two)
        {
            list = Swap(list, one, two);

            foreach (T item in list)
            {
                string type = item.GetType().FullName;
                Console.WriteLine($"{type}: {item}");
            }
        }
    }
}
