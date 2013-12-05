using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Switch_From_Switch.Problem_Set.Problem_2
{


    /// <summary>
    /// If the methods were not static then in the constructor we could
    /// initalize the collection of menuGameOptions.
    /// </summary>
    public class Problem2
    {

        #region Static Data Members

        /// <summary>
        /// The Array of MenuOptions which are Choice for the Player.
        /// </summary>
        public static MenuOption[] staticMenuGameOptions = 
        {
            new MenuOption("Start Game",StaticStartGame),
            new MenuOption("Create Player",StaticCreatePlayer),
            new MenuOption("Map Editor Mode",StaticMapEditorMode),
            new MenuOption("Options Game",StaticOptionsGame),
            new MenuOption("Quit Game",StaticQuitGame)        
        };
        #endregion

        #region Instance Data Members

        public MenuOption[] instanceMenuGameOptions;

        #endregion

        #region CTOR

        /// <summary>
        /// Initalizes a Problem1. 
        /// </summary>
        public Problem2()
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
                    new MenuOption("Start Game",InstanceStartGame),
                    new MenuOption("Create Player",InstanceCreatePlayer),
                    new MenuOption("Map Editor Mode",InstanceMapEditorMode),
                    new MenuOption("Options Game",InstanceOptionsGame),
                    //If you want to mix you can just add a static delegate.
                    new MenuOption("Quit Game",StaticQuitGame)             
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
            Console.WriteLine("Problem1: Static");
            SolveStatically();
            Console.WriteLine("Problem1: Instance");
            SolveInstancly();
        }
        /// <summary>
        /// Solves the problem statically.
        /// </summary>
        protected static void SolveStatically()
        {
            LoopOverMenuOptions(Problem2.staticMenuGameOptions);

            int choice = 0;
            GetValidUserChoice(Problem2.staticMenuGameOptions, ref choice);

            Problem2.staticMenuGameOptions[choice-1].menuMethod.Invoke();
        }
        
        /// <summary>
        /// Solve the problem with an instance.
        /// </summary>
        protected static void SolveInstancly()
        {
            Problem2 instance = new Problem2();
            LoopOverMenuOptions(instance.instanceMenuGameOptions);

            int choice = 0;
            GetValidUserChoice(instance.instanceMenuGameOptions, ref choice);

            instance.instanceMenuGameOptions[choice-1].menuMethod.Invoke();
        }

        /// <summary>
        /// Gets a valid user input choice.
        /// </summary>
        /// <param name="collection">The instance which contains the collection</param>
        /// <param name="choice">The int to store the user value.</param>
        public static void GetValidUserChoice(MenuOption[] collection, ref int choice)
        {
            bool legalInput = false;
            do
            {
                String userInput = Console.ReadLine();
                choice = int.Parse(userInput);
                legalInput = choice > 0 && choice <= collection.Length;
            } while (!legalInput);
        }

        /// <summary>
        /// Loops through the collection and prints a menu option.
        /// </summary>
        /// <param name="collection">The collection of options to display.</param>
        public static void LoopOverMenuOptions(MenuOption[] collection)
        {
            for (int i = 0; i < collection.Length; i++)
            {
                Console.WriteLine((i+1) + ": "+collection[i].option);
            }
        }

      
    }
}
