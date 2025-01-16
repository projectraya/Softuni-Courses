using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP_Pregovor
{
    public abstract class Student : Object //always
    {
        //inheritance
        public abstract void Learn(); //u can add logic but it is not needed

        public override string ToString() //overriding
        {
            return "base.ToString()";
        }

        public void DoSum() //method overloading
        {

        }
        public void DoSum(int n)
        {

        }
    }
}
