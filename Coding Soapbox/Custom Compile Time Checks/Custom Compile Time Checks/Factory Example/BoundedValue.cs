using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Custom_Compile_Time_Checks
{
    public class Bounded0To10Value
    {
        protected short backingFieldInt;
        public short Value 
        {
            get{return this.backingFieldInt;}
        }

        public Bounded0To10Value(short passedValue)
        {
            if (passedValue > 10 || passedValue < 0)
                throw new ArgumentOutOfRangeException("Value not within 0 and 10 inclusive");
            this.backingFieldInt = passedValue;
        }

    }
}
