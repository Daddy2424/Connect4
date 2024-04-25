using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Connect4_Final_Ptoject
{
    internal class AiGameBoard : GameBoard
    {

        private int _rows;
        private int _columns;
        private string[,] _arr;

        public AiGameBoard(int rows, int columns) : base(rows, columns)
        {
            _rows = rows;
            _columns = columns;
            _arr = new string[_rows, _columns];

            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    _arr[i, j] = "-";
                }
            }
        }

        // Same as playgame function but player 2 is AI 
        virtual public void AiPlayGame(Controller controller, Menu menu)
        {
            Console.Clear();
            Sounds s = new Sounds();
            var originalMargin = (Console.WindowWidth - 6) / 2;
            var leftMargin = (Console.WindowWidth - 21) / 2;
            var centerMargin = (Console.WindowWidth - 31) / 2;
            while (true)
            {
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Program.ConsoleCenter("Enter Player 1 name : ");
                string player1Name = Console.ReadLine();
                Console.WriteLine(" ");
                if (string.IsNullOrWhiteSpace(player1Name))
                {
                    Console.Clear();
                    Program.ConsoleCenter("Please enter a valid name // ");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
                else
                {
                    CreatePlayer(player1Name, "AI");
                    break;
                }
            }
            Console.Clear();
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Program.ConsoleCenter("Player 1 will be X and AI will be O ");
            Console.WriteLine(" ");
            Console.CursorLeft = originalMargin;
            Program.typeWrite("....", 1000);
            Thread.Sleep(1000);
            s.StopBgm();
            s.PlayMatch();

            int exit = 0;
            int i = 0;
            int selectedCol;
            do
            {
                Console.Clear();
                // Player 1 turn
                controller.GameBoardDisplay();
                // check draw
                if (controller.IsFull())
                {
                    s.StopMatch();
                    Console.Clear();
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.CursorLeft = leftMargin;
                    Console.WriteLine("Its a DRAW guys ! play again //");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    while (true)
                    {
                        Program.ConsoleCenter("Enter X to go to menu : ");
                        string input = Console.ReadLine();
                        if (input.ToLower() == "x")
                        {
                            menu.MenuDisplay(controller, menu);
                        }
                        else
                        {
                            Program.ConsoleCenter("Please enter valid command // ");
                        }
                    }
                }
                // Check win
                if (controller.CheckWin(player1.Turn))
                {
                    s.StopMatch();
                    Console.Clear();
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.CursorLeft = leftMargin;
                    Console.WriteLine("CONGRATS {0} You Won !", player1.Name);
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    while (true)
                    {
                        Program.ConsoleCenter("Enter X to go to menu : ");
                        string input = Console.ReadLine();
                        if (input.ToLower() == "x")
                        {
                            menu.MenuDisplay(controller, menu);
                        }
                        else
                        {
                            Program.ConsoleCenter("Please enter valid command // ");
                        }
                    }

                }
                if (controller.CheckWin(player2.Turn))
                {
                    s.StopMatch();
                    Console.Clear();
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.CursorLeft = leftMargin;
                    Console.WriteLine("CONGRATS {0} You Won !", player2.Name);
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    while (true)
                    {
                        Program.ConsoleCenter("Enter X to go to menu : ");
                        string input = Console.ReadLine();
                        if (input.ToLower() == "x")
                        {
                            menu.MenuDisplay(controller, menu);
                        }
                        else
                        {
                            Program.ConsoleCenter("Please enter valid command // ");
                        }
                    }
                }
                Console.WriteLine(" ");

                while (i == 0)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.CursorLeft = centerMargin;
                    Console.Write("Your turn {0} (Choose a number) : ", player1.Name);
                    string input = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(input))
                    {

                        Program.ConsoleCenter("Please enter a valid number.");
                        continue;
                    }
                    if (int.TryParse(input, out selectedCol))
                    {
                        if (selectedCol >= 1 && selectedCol <= 7)
                        {
                            i = 1;
                            Console.WriteLine(" ");
                            controller.ChangeBoard(selectedCol, player1.Turn);
                        }
                        else
                        {
                            Program.ConsoleCenter("Please enter a number between 1 and 7.");
                        }
                    }
                    else
                    {
                        Program.ConsoleCenter("Please enter a valid number.");
                    }
                }



                Console.Clear();
                // Player 2 turn
                controller.GameBoardDisplay();
                // Check draw
                if (controller.IsFull())
                {
                    s.StopMatch();
                    Console.Clear();
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.CursorLeft = leftMargin;
                    Console.WriteLine("Its a DRAW guys ! play again //");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    while (true)
                    {
                        Program.ConsoleCenter("Enter X to go to menu : ");
                        string input = Console.ReadLine();
                        if (input.ToLower() == "x")
                        {
                            menu.MenuDisplay(controller, menu);
                        }
                        else
                        {
                            Program.ConsoleCenter("Please enter valid command // ");
                        }
                    }
                }
                // Check win
                if (controller.CheckWin(player1.Turn))
                {
                    s.StopMatch();
                    Console.Clear();
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.CursorLeft = leftMargin;
                    Console.WriteLine("CONGRATS {0} You Won !", player1.Name);
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    while (true)
                    {
                        Program.ConsoleCenter("Enter X to go to menu : ");
                        string input = Console.ReadLine();
                        if (input.ToLower() == "x")
                        {
                            menu.MenuDisplay(controller, menu);
                        }
                        else
                        {
                            Program.ConsoleCenter("Please enter valid command // ");
                        }
                    }
                }
                if (controller.CheckWin(player2.Turn))
                {
                    s.StopMatch();
                    Console.Clear();
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.CursorLeft = leftMargin;
                    Console.WriteLine("{0} Won !", player2.Name);
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    while (true)
                    {
                        Program.ConsoleCenter("Enter X to go to menu : ");
                        string input = Console.ReadLine();
                        if (input.ToLower() == "x")
                        {
                            menu.MenuDisplay(controller, menu);
                        }
                        else
                        {
                            Program.ConsoleCenter("Please enter valid command // ");
                        }
                    }
                }
                Console.WriteLine(" ");
                while (i == 1)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Program.ConsoleCenter("AI Turn");
                    controller.AiLogic(controller);
                    i = 0;
                    Thread.Sleep(1500);

                }


            } while (exit == 0);
        }

        // I tryed my maximun to implement logic for AI but its still not getting that good
        virtual public void AiLogic(Controller controller)
        {
            Random rand = new Random();
            int selectedCol = rand.Next(1, 8);

            // Checking for winning moves by the player and blocking them
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns - 3; j++)
                {
                    if ((_arr[i, j]) == player1.Turn &&
                        _arr[i, j + 1] == player1.Turn &&
                        _arr[i, j + 2] == player1.Turn &&
                        _arr[i, j + 3] == "-")
                    {
                        selectedCol = j + 4; 
                        controller.ChangeBoard(selectedCol, player2.Turn); 
                        return;
                    }
                }
            }


            for (int i = 0; i < _columns; i++)
            {
                for (int j = 0; j < _rows - 3; j++)
                {
                    if ((_arr[j, i]) == player1.Turn &&
                        _arr[j + 1, i] == player1.Turn &&
                        _arr[j + 2, i] == player1.Turn &&
                        _arr[j + 3, i] == "-")
                    {
                        selectedCol = i + 1;
                        controller.ChangeBoard(selectedCol, player2.Turn); 
                        return;
                    }
                }
            }

            // AI winning moves
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns - 3; j++)
                {
                    if (_arr[i, j] == player2.Turn &&
                        _arr[i, j + 1] == player2.Turn &&
                        _arr[i, j + 2] == player2.Turn)
                    {
                        selectedCol = j + 4; 
                        controller.ChangeBoard(selectedCol, player2.Turn);
                        return;
                    }
                }
            }

            for (int i = 0; i < _columns; i++)
            {
                for (int j = 0; j < _rows - 3; j++)
                {
                    if (_arr[j, i] == player2.Turn &&
                        _arr[j + 1, i] == player2.Turn &&
                        _arr[j + 2, i] == player2.Turn)
                    {
                        selectedCol = i + 1; 
                        controller.ChangeBoard(selectedCol, player2.Turn);
                        return;
                    }
                }
            }

            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns - 3; j++)
                {
                    if (_arr[i, j] == player2.Turn &&
                        _arr[i, j + 1] == player2.Turn &&
                        _arr[i, j + 2] == "-")
                    {
                        selectedCol = j + 3; 
                        controller.ChangeBoard(selectedCol, player2.Turn);
                        return;
                    }
                }
            }

            
            for (int i = 0; i < _columns; i++)
            {
                for (int j = 0; j < _rows - 3; j++)
                {
                    if (_arr[j, i] == player2.Turn &&
                        _arr[j + 1, i] == player2.Turn &&
                        _arr[j + 2, i] == "-")
                    {
                        selectedCol = i + 1; 
                        controller.ChangeBoard(selectedCol, player2.Turn );
                        return;
                    }
                }
            }


            controller.ChangeBoard(selectedCol, player2.Turn);

        }

    }
}
