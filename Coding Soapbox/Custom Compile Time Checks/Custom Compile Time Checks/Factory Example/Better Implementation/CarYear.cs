using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Custom_Compile_Time_Checks.Factory_Example.Better_Implementation
{
    public class CarYear
    {
        protected short _Year;
        public short Year { get { return this._Year; } }

        //int is cls compliant
        public CarYear(short year)
        {
            //Fundamentally where should this exception be thrown? Here or in CarFactory?
            //Make sure the year is not before cars were invented or in the future.
            //http://en.wikipedia.org/wiki/History_of_the_automobile
            if (year < DateTime.Now.Year || year < 1886)
            {
                throw new ArgumentOutOfRangeException("Year is not valid");
            }
            this._Year = year;
        }
    }
}
