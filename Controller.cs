using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Connect4_Final_Ptoject
{
    internal class Controller : GameBoard
    {
        // creating a new AiGameboard as child of Gameboard
        readonly AiGameBoard gameBoard = new AiGameBoard(6, 7);

        public Controller()
        {
        }

        public override void GameBoardDisplay()
        {
            gameBoard.GameBoardDisplay();
        }

        public override void PlayGame(Controller controller, Menu menu)
        {
            gameBoard.PlayGame(controller, menu);
        }

        public void AiPlayGame(Controller controller, Menu menu)
        {
            gameBoard.AiPlayGame(controller, menu); 
        }

        public override void ChangeBoard(int selectedCol, string playerTurn)
        {
           gameBoard.ChangeBoard(selectedCol, playerTurn);
        }

        public override bool CheckWin(string playerTurn)
        {
           return gameBoard.CheckWin(playerTurn);
        }

        public override bool IsFull()
        {
            return gameBoard.IsFull();
        }

        public override void ResetBoard()
        {
            gameBoard.ResetBoard();
        }

        public void AiLogic(Controller controller)
        {
            gameBoard.AiLogic(controller);
        }

    }
}
