using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4_Final_Ptoject
{
    internal class GameBoard
    {
        private int _rows;
        private int _columns;
        private string[,] _arr;

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

        public void GameBoardDisplay()
        {
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    Console.Write(_arr[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine("");
            }
            for (int i = 1; i < _rows + 2; i++)
            {
                Console.Write(i);
                Console.Write(" ");
            }
        }

     

        
    }

}
