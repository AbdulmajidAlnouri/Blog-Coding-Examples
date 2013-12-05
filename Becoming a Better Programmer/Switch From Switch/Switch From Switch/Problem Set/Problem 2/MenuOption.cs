using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Switch_From_Switch.Problem_Set.Problem_2
{
    public class MenuOption
    {
        protected String _option;
        protected Action _menuMethod;
        public String option { get { return this._option; } }
        public Action menuMethod { get { return this._menuMethod; } }

        public MenuOption(String passedOptionName, Action passedMenuMethod)
        {
            this._option = passedOptionName;
            this._menuMethod = passedMenuMethod;
        }
    }
}
