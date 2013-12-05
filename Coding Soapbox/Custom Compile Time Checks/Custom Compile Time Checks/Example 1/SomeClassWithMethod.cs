using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Custom_Compile_Time_Checks.Example_1
{
    public class SomeClassWithMethod
    {

        [CompileTimeCheck(someParameter!=null)]
        public void SomeMethod(object someParameter)
        { 
        
        }
    }
}
