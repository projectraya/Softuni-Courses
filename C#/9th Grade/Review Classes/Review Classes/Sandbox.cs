using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_Classes
{
    public class Sandbox
    {
        //fields
        private int size;
        private string name;
        private List<int> numbers = new List<int>();

        //properties
        public int Size
        {
            get { return size; }
            set //could be private
            {
                if(value < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    size = value; 
                }
                
            
            }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        const int STARTUP_SIZE = 5;

        //constructors
        public Sandbox()
        {
            Size = STARTUP_SIZE;
            numbers = new List<int>();
        }

        public Sandbox(int size) : this()
        {
            Size = size;
        }

        public Sandbox(string name, int size) : this(size)
        {
            Name = name;
        }

    }
}
