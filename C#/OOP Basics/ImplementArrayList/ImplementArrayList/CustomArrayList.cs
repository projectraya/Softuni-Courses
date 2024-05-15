using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ImplementArrayList
{
    public class CustomArrayList
    {
        private object[] array;
        private int _count;
        public int Count
        {
            get { return _count; }
            private set { _count = value; }
        }
        private const int CAPACITY = 4; //a constant declaring a starting capacity/ You won't use it again


        public CustomArrayList() //this is a constructor which makes it easier to set the count and capacity
        {
            array = new object[CAPACITY]; //
            _count = 0;
        }

       
        public void Insert(object item, int index)
        {
            if(Count == array.Length) // checks if the current count of elements is equal to the allowed count(length)
                //basically, if the array is full, resize
            {
                Resize();
            }

            for(int i = index; i < array.Length - 1; i++)
            {
                object current = array[i];
                if (i == array.Length - 1)
                {
                    Resize();
                }
                array[i + 1] = current;
                    
            }
            array[index] = item;
            

        }
        //public int IndexOf(object item)
        //{


        //}
        //public void Clear()
        //{
        //}
        //public bool Contains(object item)
        //{
        //}
        public object this[int index]
        {
            get { return this[index]}
            
        }
        //public object Remove(int index)
        //{
        //}
        //public int Remove(object item)
        //{
        //}
        public void Add(object item)
        {
            Insert(item, array.Length - 1);

        } //TODO
        private void Resize()
        {
            object[] copy = new object[array.Length * 2];
            Array.Copy(array, copy, array.Length);
            array = copy;
           
        }
    }
}

