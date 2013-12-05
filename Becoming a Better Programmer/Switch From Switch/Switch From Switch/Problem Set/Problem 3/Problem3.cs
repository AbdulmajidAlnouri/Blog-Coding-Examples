using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Switch_From_Switch.Problem_Set.Problem_3
{


    /// <summary>
    /// If the methods were not static then in the constructor we could
    /// initalize the collection of menuGameOptions.
    /// </summary>
    public class Problem3
    {

        #region Static Data Members

        /// <summary>
        /// The Array of MenuOptions which are Choice for the Player.
        /// </summary>
        public static MenuOption[] staticMenuGameOptions = 
        {
            new MenuOption("Start Game",StaticStartGame, new String[]{"Start Game", "start", "s"}),
            new MenuOption("Create Player",StaticCreatePlayer,  new String[]{"new player", "new", "n"}),
            new MenuOption("Map Editor Mode",StaticMapEditorMode,  new String[]{"Map Editor Mode", "edit", "e"}),
            new MenuOption("Options Game",StaticOptionsGame,  new String[]{"Options Game", "options", "o"}),
            new MenuOption("Quit Game",StaticQuitGame,  new String[]{"Quit Game", "quit game", "quit", "q"})
        };
        #endregion

        #region Instance Data Members

        public MenuOption[] instanceMenuGameOptions;

        #endregion

        #region CTOR

        /// <summary>
        /// Initalizes a Problem1. 
        /// </summary>
        public Problem3()
        {
            IntializeMenuOptions();

        }

        #endregion

        /// <summary>
        /// Initalizes the Menu Options collection.
        /// </summary>
        protected virtual void IntializeMenuOptions()
        {
            instanceMenuGameOptions = new MenuOption[]
                {
                    new MenuOption("Start Game",InstanceStartGame, new String[]{"Start Game", "start", "s"}),
                    new MenuOption("Create Player",InstanceCreatePlayer, new String[]{"new player", "new", "n"}),
                    new MenuOption("Map Editor Mode",InstanceMapEditorMode, new String[]{"Map Editor Mode", "edit", "e"}),
                    new MenuOption("Options Game",InstanceOptionsGame, new String[]{"Options Game", "options", "o"}),
                    //If you want to mix you can just add a static delegate.                 
                    new MenuOption("Quit Game",StaticQuitGame, new String[]{"Quit Game", "quit game", "quit", "q"})
                };
        }

        #region Instance Game Methods
        protected void InstanceStartGame() { Console.WriteLine("InstanceStartGame() Invoked"); }
        protected void InstanceCreatePlayer() { Console.WriteLine("InstanceCreatePlayer() Invoked"); }
        protected void InstanceMapEditorMode() { Console.WriteLine("InstanceMapEditorMode() Invoked"); }
        protected void InstanceOptionsGame() { Console.WriteLine("InstanceOptionsGame() Invoked"); }
        protected void InstanceQuitGame() { Console.WriteLine("InstanceQuitGame() Invoked"); }
        #endregion

        #region Static Game Methods
        protected static void StaticStartGame() { Console.WriteLine("StaticStartGame() Invoked"); }
        protected static void StaticCreatePlayer() { Console.WriteLine("StaticCreatePlayer() Invoked"); }
        protected static void StaticMapEditorMode() { Console.WriteLine("StaticMapEditorMode() Invoked"); }
        protected static void StaticOptionsGame() { Console.WriteLine("StaticOptionsGame() Invoked"); }
        protected static void StaticQuitGame() { Console.WriteLine("StaticQuitGame() Invoked"); }
        #endregion


        /// <summary>
        /// Demonstrates how the problem can be solved using static and / or instance members.
        /// </summary>
        public static void SolveProblem()
        {
            Console.WriteLine("Problem3: Static");
            SolveStatically();
            Console.WriteLine("Problem3: Instance");
            SolveInstancly();
        }
        /// <summary>
        /// Solves the problem statically.
        /// </summary>
        protected static void SolveStatically()
        {
            LoopOverMenuOptions(Problem3.staticMenuGameOptions);

            MenuOption choice = GetValidUserChoice(Problem3ExpansionWithInheritance.staticMenuGameOptions);
            choice.menuMethod.Invoke();  
        }

        /// <summary>
        /// Solve the problem with an instance.
        /// </summary>
        protected static void SolveInstancly()
        {
            Problem3 instance = new Problem3();
            LoopOverMenuOptions(instance.instanceMenuGameOptions);

            MenuOption choice = GetValidUserChoice(instance.instanceMenuGameOptions);
            choice.menuMethod.Invoke(); 
        }

        /// <summary>
        /// Gets a valid user input choice.
        /// </summary>
        /// <param name="collection">The instance which contains the collection</param>
        /// <param name="choice">The int to store the user value.</param>
        public static MenuOption GetValidUserChoice(MenuOption[] collection)
        {
            MenuOption result = null;
            bool legalInput = false;
            do
            {
                String userInput = Console.ReadLine();
                foreach (MenuOption menuOption in collection)
                {
                    if (menuOption.aliases.Contains(userInput))
                    {
                        result = menuOption;
                        legalInput = true;
                        break;
                    }
                }
            } while (!legalInput);
            return result;
        }

        /// <summary>
        /// Loops through the collection and prints a menu option.
        /// </summary>
        /// <param name="collection">The collection of options to display.</param>
        public static void LoopOverMenuOptions(MenuOption[] collection)
        {
            for (int i = 0; i < collection.Length; i++)
            {
                Console.WriteLine((i + 1) + ": " + collection[i].option);
            }
        }
    }
}
