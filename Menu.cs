using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Connect4_Final_Ptoject
{
    internal class Menu
    {
        // displays menu and all pathways
        public void MenuDisplay(Controller controller, Menu menu)
        {
            Sounds s = new Sounds();
            Console.Clear();
            var leftMargin = (Console.WindowWidth - 11) / 2;
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            s.PlayBgm();
            Console.CursorLeft = leftMargin;
            Program.typeWrite("CONNECT FOUR");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Program.ConsoleCenter("1. Play Game ( Player vs Player ) ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Program.ConsoleCenter("2. Play Game ( Player vs AI ) ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Program.ConsoleCenter("3. Exit ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Program.ConsoleCenter(" // More options coming soon //");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            int originalCursorTop = Console.CursorTop;
            Console.SetCursorPosition(0, Console.WindowHeight - 3);
            Program.ConsoleCenter("Copyright © 2024 Deepak Poly. All rights reserved.");
            Console.WriteLine(" ");
            Program.ConsoleCenter("PIXELPULSE Studios");
            Console.SetCursorPosition(0, originalCursorTop);


            while (true)
            {
                string inputStr;
                while (true)
                {
                    Program.ConsoleCenter("(Enter as number) => ");
                    inputStr = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(inputStr))
                    {
                        Program.ConsoleCenter("// Invalid input //");
                        Console.WriteLine("");
                    }
                    else
                    {
                        break;
                    }
                }
                
                Console.WriteLine(" ");
                if (inputStr == "1")
                {
                    controller.ResetBoard();
                    controller.PlayGame(controller, menu);

                }
                else if (inputStr == "2")
                {
                    Console.Clear();
                    Program.ConsoleCenter("Player Vs AI (Beta version)");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Program.ConsoleCenter(" Press any key to continue ");
                    Console.ReadKey();
                    controller.ResetBoard();
                    controller.AiPlayGame(controller, menu);
                }
                else if (inputStr == "3")
                {
                    Console.Clear();
                    Program.ConsoleCenter(" Are you sure you want to quit ?");
                    Console.WriteLine(" ");
                    Program.ConsoleCenter("Press ENTER key to go to menu or X to quit : ");
                    string temp = Console.ReadLine();
                    if (temp.ToLower() == "x")
                    {
                        Environment.Exit(0);
                    }
                    MenuDisplay(controller, menu);
                }
            }

            
        }

    }

}

