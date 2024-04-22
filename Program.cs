using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4_Final_Ptoject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.ReadKey();
            ConsoleCenter("CONNECT FOUR");

            Player player1 = new Player();
            Player player2 = new Player();
            

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            ConsoleCenter("Enter Player 1 name : ");
            player1.Name = Console.ReadLine();
            player1.Turn = "X";
            Console.WriteLine(" ");
            ConsoleCenter("Enter Player 2 name : ");
            player2.Name = Console.ReadLine();
            player2.Turn = "O";

            // Creating Gameboard
            GameBoard gameBoard = new GameBoard(6, 7);
            Controller controller = new Controller(gameBoard);

            int exit = 0;
            int i = 0;
            int selectedCol;
            do
            {
                Console.Clear();
                // Player 1 turn
                gameBoard.GameBoardDisplay();
                Console.WriteLine(" ");

                while (i == 0)
                {
                    Console.Write("Your turn {0} (Choose a number) : ", player1.Name);
                    string input = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(input))
                    {
                   
                        Console.WriteLine("Please enter a valid number.");
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
                            Console.WriteLine("Please enter a number between 1 and 7.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number.");
                    }
                }



                Console.Clear();
                // Player 2 turn
                gameBoard.GameBoardDisplay();
                Console.WriteLine(" ");
                while (i == 1)
                {
                    Console.Write("Your turn {0} (Choose a number) : ", player2.Name);
                    string input = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(input))
                    {
                        Console.WriteLine("Please enter a valid number.");
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
                            Console.WriteLine("Please enter a number between 1 and 7.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number.");
                    }
                }


            } while (exit == 0);

        }





        public static void ConsoleCenter(string text)
        {

            int totalWidth = Console.WindowWidth;
            int textWidth = text.Length;
            int padding = (totalWidth - textWidth) / 2;

            Console.Write(string.Format("{0," + (padding + textWidth) + "}", text));

        }

    }
}
