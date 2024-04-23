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
        public void MenuDisplay(Controller controller, Menu menu)
        {
            Console.Clear();
            var leftMargin = (Console.WindowWidth - 11) / 2;
            Console.WriteLine(" ");
            Console.WriteLine(" ");
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

