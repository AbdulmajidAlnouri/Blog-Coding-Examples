using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Custom_Compile_Time_Checks.Custom_Compile_Time_Check
{
    public class Car
    {
        protected Model _CarModel;
        public Model CarModel
        {
            get { return this._CarModel; }
        }

        protected short _Year;
        public short Year { get { return this._Year; } }
        
        [CompileTimeCheck(year>0 && year<DateTime.Today.Year)]
        public Car(Model model, short year)
        {
            //Fundamentally where should this exception be thrown? Here or in CarFactory?
            //Make sure the year is not before cars were invented or in the future.
            //http://en.wikipedia.org/wiki/History_of_the_automobile
            if (year < DateTime.Now.Year || year < 1886)
            {
                throw new ArgumentOutOfRangeException("Year is not valid");
            }
            this._CarModel = model;
            this._Year = year;
        }

    }
}