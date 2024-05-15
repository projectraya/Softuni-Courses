using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Implementing_Queue
{
    public class CircularQueue
    {
        
        private const int InitialCapacity = 16;

        private int[] elements;
        private int startIndex;
        private int endIndex;
        private int capacity;

        public int Count { get; private set; }

        public CircularQueue(int capacity)
        {
            // TODO
            capacity = capacity;
            
        }

        public void Enqueue(int element)
        {
            // TODO
        }

        public int Dequeue()
        {
            // TODO
            throw new NotImplementedException();
        }

        public int[] ToArray()
        {
            // TODO
            throw new NotImplementedException();
        }
    }
}
