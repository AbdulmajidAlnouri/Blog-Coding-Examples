using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Custom_Compile_Time_Checks.Example_1
{
    public class Main
    {
        public void main()
        {
            SomeClassWithMethod instance = new SomeClassWithMethod();
            object argument = null;
            instance.SomeMethod(argument);
        }
    }
}
