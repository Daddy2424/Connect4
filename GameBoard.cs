using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Connect4_Final_Ptoject
{
    internal class GameBoard : Player
    {
        private int _rows;
        private int _columns;
        private string[,] _arr;

        public GameBoard()
        { }

        public GameBoard(int rows, int columns)
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

        public string[,] Array
        {
            get { return _arr; }
            set { _arr = value; } 
        }

        public int Rows
        {
            get { return _rows; }
        }

        public int Columns
        {
            get { return _columns; }
        }

        // function to display gameboard
        virtual public void GameBoardDisplay()
        {
            Console.WriteLine(" ");
            Program.ConsoleCenter("CONNECT FOUR");
            Console.WriteLine(" ");
            var leftMargin = (Console.WindowWidth - 11) / 2;
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            for (int i = 0; i < _rows; i++)
            {
                Console.CursorLeft = leftMargin;
                for (int j = 0; j < _columns; j++)
                {
                    Console.Write(_arr[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine("");
            }

            Console.CursorLeft = leftMargin;
            for (int i = 1; i < _rows + 2; i++)
            {
                Console.Write(i);
                Console.Write(" ");
            }
        }
        
        // function to change board state
        virtual public void ChangeBoard(int selectedCol, string playerTurn)
        {
            while (true)
            {
                if (selectedCol >= 1 && selectedCol <= _columns)
                {
                    int row = _rows - 1;
                    while (row >= 0)
                    {
                        if (_arr[row, selectedCol - 1] == "-")
                        {
                            _arr[row, selectedCol - 1] = playerTurn;
                            return;
                        }
                        row--;
                    }
                }
                Console.WriteLine(" ");
                Program.ConsoleCenter("Column is full!");
                Thread.Sleep(1000);

                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Program.ConsoleCenter("Please choose another column: ");
                selectedCol = int.Parse(Console.ReadLine());
            }
            
        }

        // play game function (All game logic goes here)
        virtual public void PlayGame(Controller controller,Menu menu)
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
                Program.ConsoleCenter("Enter Player 2 name : ");
                string player2Name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(player1Name) || string.IsNullOrWhiteSpace(player2Name))
                {
                    Console.Clear();
                    Program.ConsoleCenter("Please enter a valid name // ");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
                else
                {
                    CreatePlayer(player1Name, player2Name);
                    break;
                }
            }
            Console.Clear();
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Program.ConsoleCenter("Player 1 will be X and Player 2 will be O ");
            Console.WriteLine(" ");
            Console.CursorLeft = originalMargin;
            Program.typeWrite("...." , 1000);
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
                        s.StopMatch();
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
                    Console.CursorLeft = leftMargin ;
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
                while (i == 1)
                {

                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.CursorLeft = centerMargin;
                    Console.Write("Your turn {0} (Choose a number) : ", player2.Name);
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
                            i = 0;
                            Console.WriteLine(" ");
                            controller.ChangeBoard(selectedCol, player2.Turn);
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


            } while (exit == 0);
        }

         virtual public bool CheckWin(string playerTurn)
        {
            // check horizontal wins
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns - 3; j++)
                {
                    if ((_arr[i, j]) == playerTurn &&
                        _arr[i, j + 1] == playerTurn &&
                        _arr[i, j + 2] == playerTurn &&
                        _arr[i, j + 3] == playerTurn)
                    {
                        Thread.Sleep(1000);
                        return true;
                    }
                }
            }

            // Check vertical wins
            for (int i = 0; i < _columns; i++)
            {
                for (int j = 0; j < _rows - 3; j++)
                {
                    if ((_arr[j, i]) == playerTurn &&
                        _arr[j + 1, i] == playerTurn &&
                        _arr[j + 2, i] == playerTurn &&
                        _arr[j + 3, i] == playerTurn)
                    {
                        Thread.Sleep(1000);
                        return true;
                    }
                }
            }

            // check diagnol wins
            for (int i = 0; i < _rows - 3; i++)
            {
                for (int j = 0; j < _columns - 3; j++)
                {
                    if ((_arr[i, j]) == playerTurn &&
                        _arr[i + 1, j + 1] == playerTurn &&
                        _arr[i + 2, j + 2] == playerTurn &&
                        _arr[i + 3, j + 3] == playerTurn)
                    {
                        Thread.Sleep(1000);
                        return true;
                    }
                }
            }

            for (int i = 0; i < _rows - 3; i++)
            {
                for (int j = _columns - 1; j >= 3; j--)
                {
                    if ((_arr[i, j]) == playerTurn &&
                        _arr[i + 1, j - 1] == playerTurn &&
                        _arr[i + 2, j - 2] == playerTurn &&
                        _arr[i + 3, j - 3] == playerTurn)
                    {
                        Thread.Sleep(1000);
                        return true;
                    }
                }
            }

            return false;
        }

       // if board is full
        virtual public bool IsFull()
        {
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    if(_arr[i, j] == "-")
                    {
                        return false;
                    }
                    
                }
            }
            return true;
        }

        // function to reset board
        virtual public void ResetBoard()
        {
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    _arr[i, j] = "-";
                }
            }
        }
    }

        
}


