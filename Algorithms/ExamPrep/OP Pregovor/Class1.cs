using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP_Pregovor
{
    public class Class1 : Student
    {
        //public - can be changed even in the main
        //protected - can be chaned by all classes which inherit this one
        //private - cannot be changed by any other classes

        //setter 
        public override void Learn()
        {
            throw new NotImplementedException();
        }
    }
}
