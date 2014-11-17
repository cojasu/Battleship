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

        public Board()
        {
            upperScreen = new UpperScreen();
            lowerScreen = new LowerScreen();
        }
    }
}
