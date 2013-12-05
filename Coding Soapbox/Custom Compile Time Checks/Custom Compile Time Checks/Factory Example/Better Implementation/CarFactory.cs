using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Custom_Compile_Time_Checks.Factory_Example.Better_Implementation
{
    public class CarFactory
    {
        //By placing CarYear here we ensure the Factory will not have any problems!
        public Car[] GenerateCars(Model model, CarYear year, int amount)
        {
            Car[] result = new Car[amount];
            for (int i = 0; i < amount; i++)
            {
                result[i] = new Car(model, year);
            }

            return result;
        }
    }
}
