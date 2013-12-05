using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using Switch_From_Switch.Problem_Set.Problem_1;

namespace Switch_From_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Problem1.SolveProblem();
            Problem1ExpansionWithInheritance.SolveProblem();
        }



        static void MaintainabilityExample()
        {
            int choice = 0;
            switch (choice)
            {
                case 0:
                    Console.WriteLine("0");
                    break;
                case 1:
                    Console.WriteLine("1");
                    break;
                case 2:
                    Console.WriteLine("2");
                    break;

                //Added Code Cases
                case 3:
                    Console.WriteLine("3");
                    break;
                case 4:
                    Console.WriteLine("4");
                    break;
                case 5:
                    Console.WriteLine("5");
                    break;
                //End of added Code Cases

                default:
                    Console.WriteLine("default...");
                    break;
            }
        }
        static void StaticAnaylsisExample()
        {
            String choice = "choiceZero";
            String caseValue = "choiceOne";
            switch (choice)
            {
                case "choiceZero":
                    Console.WriteLine("Choice Zero Selected");
                    break;
                case /* causes error: caseValue: // */ "choiceOne":
                    Console.WriteLine("Choice One Selected");
                    break;
                case "choiceTwo":
                    Console.WriteLine("Choice Two Selected");
                    break;

                default:
                    Console.WriteLine("Default");
                    break;
            }
        }
        static void DuplicateCaseBodyExample()
        {
            int choice = 0;
            switch (choice)
            {
                case 0:
                    Console.WriteLine("0 or 3 Selected");
                    break;
                //Duplicate Case Body.
                case 3:
                    Console.WriteLine("0 or 3 Selected");
                    break;
                //End Duplicate
                case 1:
                    Console.WriteLine("1, 4, 5 or 6 Selected");
                    break;
                //Duplicate Case Body.
                case 4:
                    Console.WriteLine("1, 4, 5 or 6 Selected");
                    break;
                case 5:
                    Console.WriteLine("1, 4, 5 or 6 Selected");
                    break;
                case 6:
                    Console.WriteLine("1, 4, 5 or 6 Selected");
                    break;
                //End Duplicate
                case 2:
                    Console.WriteLine("2 Selected");
                    break;

                default:
                    Console.WriteLine("Default");
                    break;
            }

        }
        static void ComplexSwitchExpressionsExample()
        {
            //Totally Illegal Code
            //int choice = 0;
            //switch (choice)
            //{
            //    case EvenAndMultipleOf3(choice):
            //        Console.WriteLine("Even and 3!");
            //        break;
            //    case IsPrime(choice):
            //        Console.WriteLine("Is a Prime!");
            //        break;
            //    case EvenAndMultipleOf4(choice):
            //        Console.WriteLine("Even and 4!");
            //        break;

            //    default:
            //        Console.WriteLine("Default");
            //        break;
            //}

        }

    }
}
