using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BattleshipTest.BoardData
{

    public class Board
    {
        public UpperScreen upperScreen;
        public LowerScreen lowerScreen;

        public Board(bool dm)
        {
            upperScreen = new UpperScreen(dm);
            lowerScreen = new LowerScreen(dm);
        }
    }
}
