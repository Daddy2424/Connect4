using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Connect4_Final_Ptoject
{
    internal class Controller : Player
    {
        // creating a new AiGameboard as child of Gameboard
        readonly AiGameBoard gameBoard = new AiGameBoard(6, 7);

        public Controller()
        {
        }

        public void GameBoardDisplay()
        {
            gameBoard.GameBoardDisplay();
        }

        public void PlayGame(Controller controller, Menu menu)
        {
            gameBoard.PlayGame(controller, menu);
        }

        public void AiPlayGame(Controller controller, Menu menu)
        {
            gameBoard.AiPlayGame(controller, menu); 
        }

        public void ChangeBoard(int selectedCol, string playerTurn)
        {
           gameBoard.ChangeBoard(selectedCol, playerTurn);
        }

        public bool CheckWin(string playerTurn)
        {
           return gameBoard.CheckWin(playerTurn);
        }

        public bool IsFull()
        {
            return gameBoard.IsFull();
        }

        public void ResetBoard()
        {
            gameBoard.ResetBoard();
        }

        public void AiLogic(Controller controller)
        {
            gameBoard.AiLogic(controller);
        }

    }
}
