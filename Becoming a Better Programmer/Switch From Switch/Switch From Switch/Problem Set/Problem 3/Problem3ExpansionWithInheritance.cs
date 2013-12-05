using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Switch_From_Switch.Problem_Set.Problem_3
{
    /// <summary>
    /// Here is the answer to how inheritance could also be used to make the code more flexible.
    /// </summary>
    public class Problem3ExpansionWithInheritance : Problem3
    {

        #region Static Data Members
        
        /// <summary>
        /// The Array of MenuOptions which are Choice for the Player.
        /// </summary>
        public static MenuOption[] staticMenuGameOptions = 
        {
            //All that was done was a simple re-ordering, adding, and removing of menu options            
            new MenuOption("Create Player",StaticCreatePlayer, new String[]{"new player", "new", "n"}),
            new MenuOption("Map Editor Mode",StaticMapEditorMode, new String[]{"Map Editor Mode", "edit", "e"}),
            new MenuOption("Online Mode",StaticOnlineMode, new String[]{"Online Mode", "online"}),
            new MenuOption("Offline Mode",StaticOfflineMode, new String[]{"Offline Mode", "offline"}),
            new MenuOption("Co-Op Story Mode",StaticCoOpStoryMode, new String[]{"Co-Op Story Mode", "story", "s"}),
            new MenuOption("Options Game",StaticOptionsGame, new String[]{"Options Game", "options", "o"}),
            new MenuOption("Quit Game",StaticQuitGame, new String[]{"Quit Game", "quit game", "quit", "q"})           
        };
        #endregion

        #region CTOR

        /// <summary>
        /// Initalizes a Problem1ExpansionWithInheritance. 
        /// </summary>
        public Problem3ExpansionWithInheritance():base()
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
                    new MenuOption("Create Player",InstanceCreatePlayer, new String[]{"new player", "new", "n"}),          
                    new MenuOption("Map Editor Mode",InstanceMapEditorMode, new String[]{"Map Editor Mode", "edit", "e"}),          
                    new MenuOption("Online Mode",InstanceOnlineMode, new String[]{"Online Mode", "online"}),          
                    new MenuOption("Offline Mode",InstanceOfflineMode, new String[]{"Offline Mode", "offline"}),          
                    new MenuOption("Co-Op Story Mode",InstanceCoOpStoryMode, new String[]{"Co-Op Story Mode", "story", "s"}),          
                    new MenuOption("Options Game",InstanceOptionsGame, new String[]{"Options Game", "options", "o"}),  
        
                    //If you want to mix you can just add a static method!                  
                    new MenuOption("Quit Game",StaticQuitGame, new String[]{"Quit Game", "quit game", "quit", "q"}) 
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
            Console.WriteLine("Problem3Expansion: Static");
            SolveStatically();
            Console.WriteLine("Problem3Expansion: Instance");
            SolveInstancly();
        }

        /// <summary>
        /// Solves the problem statically.
        /// </summary>
        protected static void SolveStatically()
        {
            LoopOverMenuOptions(Problem3ExpansionWithInheritance.staticMenuGameOptions);

            MenuOption choice = GetValidUserChoice(Problem3ExpansionWithInheritance.staticMenuGameOptions);
            choice.menuMethod.Invoke();  
        }

        /// <summary>
        /// Solve the problem with an instance.
        /// </summary>
        protected static void SolveInstancly()
        {
            Problem3ExpansionWithInheritance instance = new Problem3ExpansionWithInheritance();
            LoopOverMenuOptions(instance.instanceMenuGameOptions);
            
            MenuOption choice = GetValidUserChoice(instance.instanceMenuGameOptions);
            choice.menuMethod.Invoke();            
        }
    }
}
