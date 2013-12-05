﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Switch_From_Switch.Problem_Set.Problem_1
{
    /// <summary>
    /// The Expansion part. We shoudl also try and use inheritance to see if we can save some code!
    /// How flexible is our design?
    /// </summary>
    public class Problem1Expansion
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

        public MenuOption[] instanceMenuGameOptions;
        public Problem1Expansion()
        {
            IntializeMenuOptions();

        }

        /// <summary>
        /// Initalizes the Menu Options collection.
        /// </summary>
        protected void IntializeMenuOptions()
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
        //No longer needed.
        //void InstanceStartGame() { Console.WriteLine("InstanceStartGame() Invoked"); }
        void InstanceCreatePlayer() { Console.WriteLine("InstanceCreatePlayer() Invoked"); }
        void InstanceMapEditorMode() { Console.WriteLine("InstanceMapEditorMode() Invoked"); }
        void InstanceOptionsGame() { Console.WriteLine("InstanceOptionsGame() Invoked"); }
        void InstanceQuitGame() { Console.WriteLine("InstanceQuitGame() Invoked"); }

        //Added methods
        static void InstanceOnlineMode() { Console.WriteLine("InstanceOnlineMode() Invoked"); }
        static void InstanceOfflineMode() { Console.WriteLine("InstanceOfflineMode() Invoked"); }
        static void InstanceCoOpStoryMode() { Console.WriteLine("InstanceCoOpStoryMode() Invoked"); }

        #endregion

        #region Static Game Methods

        //No longer needed
        //static void StaticStartGame() { Console.WriteLine("StaticStartGame() Invoked");}
        protected static void StaticCreatePlayer() { Console.WriteLine("StaticCreatePlayer() Invoked"); }
        protected static void StaticMapEditorMode() { Console.WriteLine("StaticMapEditorMode() Invoked"); }
        protected static void StaticOptionsGame() { Console.WriteLine("StaticOptionsGame() Invoked"); }
        protected static void StaticQuitGame() { Console.WriteLine("StaticQuitGame() Invoked"); }

        //Added methods
        protected static void StaticOnlineMode() { Console.WriteLine("StaticOnlineMode() Invoked"); }
        protected static void StaticOfflineMode() { Console.WriteLine("StaticOfflineMode() Invoked"); }
        protected static void StaticCoOpStoryMode() { Console.WriteLine("StaticCoOpStoryMode() Invoked"); }
        #endregion


        /// <summary>
        /// Demonstrates how the problem can be solved using static and / or instance members.
        /// </summary>
        public static void SolveProblem()
        {
            //No Code in Here was touched! All That was changed was the creation of the new methods
            //and creating new MenuOption objects for the new options!
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
            Problem1.LoopOverMenuOptions(Problem1Expansion.staticMenuGameOptions);

            int choice = 0;
            Problem1.GetValidUserChoice(Problem1Expansion.staticMenuGameOptions, ref choice);

            Problem1Expansion.staticMenuGameOptions[choice-1].menuMethod.Invoke();
        }    
        
        /// <summary>
        /// Solve the problem with an instance.
        /// </summary>
        protected static void SolveInstancly()
        {
            Problem1Expansion instance = new Problem1Expansion();
            Problem1.LoopOverMenuOptions(instance.instanceMenuGameOptions);

            int choice = 0;
            Problem1.GetValidUserChoice(instance.instanceMenuGameOptions, ref choice);

            instance.instanceMenuGameOptions[choice-1].menuMethod.Invoke();
        }

      

    }
}
