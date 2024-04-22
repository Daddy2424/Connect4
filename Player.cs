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
    }
}
