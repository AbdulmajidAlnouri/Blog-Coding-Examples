using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Switch_From_Switch.Problem_Set.Problem_3
{
    public class MenuOption
    {
        #region Data Members

        protected String _option;
        public String option { get { return this._option; } }

        protected Action _menuMethod;
        public Action menuMethod { get { return this._menuMethod; } }

        protected String[] _aliases;
        public String[] aliases { get { return this._aliases; } }

        #endregion

        public MenuOption(String passedOptionName, Action passedMenuMethod, String[] passedAliases)
        {
            this._option = passedOptionName;
            this._menuMethod = passedMenuMethod;
            this._aliases = passedAliases;
        }
    }
}
