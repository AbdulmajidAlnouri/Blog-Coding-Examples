using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Custom_Compile_Time_Checks.Factory_Example
{
    public class CarFactory
    {        
        public Car[] GenerateCars(Model model, short year, int amount)
        {
            //Fundamentally where should this exception be thrown? Here or in Cars?
            //Make sure the year is not before cars were invented or in the future.
            //http://en.wikipedia.org/wiki/History_of_the_automobile
            if (year < DateTime.Now.Year || year < 1886) 
            { 
                throw new ArgumentOutOfRangeException("Year is not valid"); 
            }

            Car[] result = new Car[amount];
            for (int i = 0; i < amount; i++)
            {
                result[i] = new Car(model, year);
            }

            return result;
        }
    }
}
