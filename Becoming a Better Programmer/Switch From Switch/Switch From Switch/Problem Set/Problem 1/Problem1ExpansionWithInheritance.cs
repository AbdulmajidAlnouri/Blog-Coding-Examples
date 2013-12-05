using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Switch_From_Switch.Problem_Set.Problem_1
{
    /// <summary>
    /// Here is the answer to how inheritance could also be used to make the code more flexible.
    /// </summary>
    public class Problem1ExpansionWithInheritance : Problem1
    {

        #region Static Data Members
        
        /// <summary>
        /// The Array of MenuOptions which are Choice for the Player.
        /// </summary>
        public static MenuOption[] staticMenuGameOptions = 
        {
            //All that was done was a simple re-ordering, adding, and removing of menu options            
            new MenuOption("Create Player",StaticCreatePlayer),
            new MenuOption("Map Editor Mode",StaticMapEditorMode),
            new MenuOption("Online Mode",StaticOnlineMode),
            new MenuOption("Offline Mode",StaticOfflineMode),
            new MenuOption("Co-Op Story Mode",StaticCoOpStoryMode),
            new MenuOption("Options Game",StaticOptionsGame),
            new MenuOption("Quit Game",StaticQuitGame)        
        };
        #endregion

        #region CTOR

        /// <summary>
        /// Initalizes a Problem1ExpansionWithInheritance. 
        /// </summary>
        public Problem1ExpansionWithInheritance():base()
        {            
        }

        #endregion

        /// <summary>
        /// Initalizes the Menu Options collection.
        /// </summary>
        protected override void IntializeMenuOptions()
        {
            instanceMenuGameOptions = new MenuOption[]
                {
                    //All that was done was a simple re-ordering, adding, and removing of menu options            
                    new MenuOption("Create Player",InstanceCreatePlayer),
                    new MenuOption("Map Editor Mode",InstanceMapEditorMode),
                    new MenuOption("Online Mode",InstanceOnlineMode),
                    new MenuOption("Offline Mode",InstanceOfflineMode),
                    new MenuOption("Co-Op Story Mode",InstanceCoOpStoryMode),
                    new MenuOption("Options Game",InstanceOptionsGame),            
                    //If you want to mix you can just add a static method!
                    new MenuOption("Quit Game",StaticQuitGame)             
                };
        }

        #region Instance Game Methods
        //Added methods
        static void InstanceOnlineMode() { Console.WriteLine("InstanceOnlineMode() Invoked"); }
        static void InstanceOfflineMode() { Console.WriteLine("InstanceOfflineMode() Invoked"); }
        static void InstanceCoOpStoryMode() { Console.WriteLine("InstanceCoOpStoryMode() Invoked"); }

        #endregion

        #region Static Game Methods
        //Added methods
        static void StaticOnlineMode() { Console.WriteLine("StaticOnlineMode() Invoked"); }
        static void StaticOfflineMode() { Console.WriteLine("StaticOfflineMode() Invoked"); }
        static void StaticCoOpStoryMode() { Console.WriteLine("StaticCoOpStoryMode() Invoked"); }
        #endregion


        /// <summary>
        /// Demonstrates how the problem can be solved using static and / or instance members.
        /// </summary>
        public static void SolveProblem()
        {
            Console.WriteLine("Problem1Expansion: Static");
            SolveStatically();
            Console.WriteLine("Problem1Expansion: Instance");
            SolveInstancly();
        }

        /// <summary>
        /// Solves the problem statically.
        /// </summary>
        protected static void SolveStatically()
        {
            LoopOverMenuOptions(Problem1ExpansionWithInheritance.staticMenuGameOptions);

            int choice = 0;
            GetValidUserChoice(Problem1ExpansionWithInheritance.staticMenuGameOptions, ref choice);

            Problem1ExpansionWithInheritance.staticMenuGameOptions[choice-1].menuMethod.Invoke();
        }

        /// <summary>
        /// Solve the problem with an instance.
        /// </summary>
        protected static void SolveInstancly()
        {
            Problem1ExpansionWithInheritance instance = new Problem1ExpansionWithInheritance();
            LoopOverMenuOptions(instance.instanceMenuGameOptions);

            int choice = 0;
            GetValidUserChoice(instance.instanceMenuGameOptions, ref choice);

            instance.instanceMenuGameOptions[choice-1].menuMethod.Invoke();
        }
    }
}
