using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleshipTest.BoardData;

namespace BattleshipTest
{
    class demoManager
    {
        public ComputerPlayer c1;
        public Board testBoard;

        public demoManager()
        {
            c1 = new ComputerPlayer("hard", false);
            testBoard = new Board(false);
        }

        public bool update()
        {
            c1.board.upperScreen.listofOpponentsSunkShips = testBoard.lowerScreen.getListofDeadShips();
            c1.board.upperScreen.updateHeatMap(testBoard.lowerScreen);
            c1.turn(testBoard, false);
            if (c1.CheckWin(testBoard.lowerScreen.Ships))
            {
                return true;
            }  
            return false;
        }
    }
}
