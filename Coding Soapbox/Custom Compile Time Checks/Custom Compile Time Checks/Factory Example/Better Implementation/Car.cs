using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Custom_Compile_Time_Checks.Factory_Example.Better_Implementation
{
    public class Car
    {
        protected Model _CarModel;
        public Model CarModel
        {
            get { return this._CarModel; }
        }

        protected CarYear _Year;
        public CarYear Year { get { return this._Year; } }

        public Car(Model model, CarYear year)
        {
            this._CarModel = model;
            this._Year = year;
        }

    }
}
