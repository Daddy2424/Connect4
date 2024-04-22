using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Connect4_Final_Ptoject
{
    internal class Controller
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


        public void ChangeBoard(int selectedCol, string playerTurn)
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
            Console.WriteLine("Column is full! no chance no more...");
            Thread.Sleep(2000);
        }

    }
}
