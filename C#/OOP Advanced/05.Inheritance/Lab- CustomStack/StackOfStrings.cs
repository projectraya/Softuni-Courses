using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStack
{
    public class StackOfStrings : Stack<string>
    {
        public bool IsEmpty()
        {
            bool result = true;
            if(this.Count > 0)
            {
                result = false;
            }
            return result;
        }

        public void AddRange(Stack<string> stack)
        {
            foreach(string element in stack)
            {
                this.Push(element);
            }
            
            
        }
    }
}
