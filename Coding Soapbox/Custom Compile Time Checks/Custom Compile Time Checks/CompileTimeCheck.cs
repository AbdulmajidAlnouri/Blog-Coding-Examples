using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Custom_Compile_Time_Checks
{
    public class CompileTimeCheckAttribute : Attribute
    {
        public CompileTimeCheckAttribute(bool passedExpression)
        {
            if (!passedExpression)
            {
                throw new Exception("Illegal parameter");
            }
        }
    }
}
