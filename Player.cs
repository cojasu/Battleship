using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleshipTest.BoardData;

namespace BattleshipTest
{
    public class Player
    {
        public Board board;

        public Player()
        {
            board = new Board();
        }
        //Logic for players turn, return true if player has won.
        public bool turn()
        {

            return false;
        }
        public Coordinate chooseMove()
        {
            Coordinate tempCoord = new Coordinate();
            return tempCoord;
        }
    }
}
