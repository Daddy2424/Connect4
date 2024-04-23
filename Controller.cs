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
        private GameBoard _gameBoard;
        private string[,] _arr;
        private int _rows;
        private int _columns;


        public Controller(GameBoard gameBoard)
        {
            _gameBoard = gameBoard;
            _arr = gameBoard.Array;
            _rows = gameBoard.Rows;
            _columns = gameBoard.Columns;
        }

        public void GameBoardDisplay()
        {
            _gameBoard.GameBoardDisplay();
        }

        public void PlayGame(Controller controller, Menu menu)
        {
            _gameBoard.PlayGame(controller, menu);
        }

        public void ChangeBoard(int selectedCol, string playerTurn)
        {
           _gameBoard.ChangeBoard(selectedCol, playerTurn);
        }

        public bool CheckWin(string playerTurn)
        {
           return _gameBoard.CheckWin(playerTurn);
        }


    }
}
