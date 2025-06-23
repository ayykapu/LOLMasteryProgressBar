using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class MenuMeneger
    {
        public static void Menu(bool isFirstTime = false)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            string helloMessage = @"
  __  __             _              ___                               ___           
 |  \/  |__ _ ___ __| |_ _ _ _  _  | _ \_ _ ___  __ _ _ _ ___ ______ | _ ) __ _ _ _ 
 | |\/| / _` / -_|_-<  _| '_| || | |  _/ '_/ _ \/ _` | '_/ -_|_-<_-< | _ \/ _` | '_|
 |_|  |_\__,_\___/__/\__|_|  \_, | |_| |_| \___/\__, |_| \___/__/__/ |___/\__,_|_|  
                             |__/               |___/                               
";
            Console.WriteLine(helloMessage);
            Console.ResetColor();
            if (isFirstTime)
            {
                //Console.WriteLine("Hello " + Program.Nickname + "!");
                Console.WriteLine("Hello " + "ayykapu" + "!");
            }
            else
            {
                Console.WriteLine("Logged as " + Program.Nickname + ".");
            }
            Console.WriteLine("You are currently at " + Methods.fiveOrMore + " champions done.\n");
            Methods.ProgressBar(20, Methods.fiveOrMore, Methods.championNames.Count());
            Console.WriteLine("\n");
            MenuService();
        }

        public static void UserService()
        {
            string input;
            bool doLoop;

            do
            {
                doLoop = false;
                Console.WriteLine("Insert your nickname and tag: ");
                input = Console.ReadLine();
                string[] combinedInput = input.Split("#");

                if (combinedInput.Length == 2 && combinedInput[1] != "")
                {
                    Program.Nickname = combinedInput[0];
                    Program.Tag = combinedInput[1];
                }
                /// development only
                else if (combinedInput[0] == "me")
                {
                    Program.Nickname = "kapupa";
                    Program.Tag = "balls";
                }
                ////
                else
                {
                    Console.WriteLine("\n\nWrong nickname, try again.");
                    doLoop = true;
                }
            } while (doLoop == true);
        }
        public static void MenuService()
        {
            string command;
            bool doLoop;
            do
            {
                doLoop = false;
                Console.WriteLine("Select action. Type HELP for help.");
                command = Console.ReadLine().ToUpper();
                switch (command)
                {
                    case "DISPLAY ALL":
                        Methods.Display("DISPLAY ALL");
                        break;
                    case "DISPLAY DONE":
                        Methods.Display("DISPLAY DONE");
                        break;
                    case "DISPLAY MISSING":
                        Methods.Display("DISPLAY MISSING");
                        break;
                    case "COMPARE":
                        Methods.Compare();
                        break;
                    case "HELP":
                        Methods.Help();
                        break;
                    case "DISCONNECT":
                        Methods.Disconnect();
                        break;
                    case "EXIT":
                        Methods.Exit();
                        break;
                    default:
                        Console.WriteLine("\nInvalid command, try again.");
                        doLoop = true;
                        break;
                }
            } while (doLoop == true);
        }
    }
}
