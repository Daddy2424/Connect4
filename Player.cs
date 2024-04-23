using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4_Final_Ptoject
{
    internal class Player
    {   
        private string _playerName {get;set;}
        private string _playerTurn { get;set;}

        protected Player player1;
        protected Player player2;
        public string Name
        {
            get { return _playerName; }
            set { _playerName = value; }
        }

        public string Turn
        {
            get { return _playerTurn; }
            set { _playerTurn = value; }
        }

        public void CreatePlayer(string p1Name, string p2Name)
        {
            player1 = new Player();
            player2 = new Player();
            player1.Name = p1Name;
            player1.Turn = "X";
            player2.Name = p2Name;
            player2.Turn = "O";
        }
    }
}
