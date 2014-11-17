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
        Ship carrier();
        Ship battleship();
        Ship submarine();
        Ship destroyer();
        Ship boat();

        public Player()
        {
            board = new Board();
        }
    }
}
