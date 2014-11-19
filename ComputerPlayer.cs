using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipTest
{
    class ComputerPlayer
    {
        AI ai;
        ComputerPlayer()
        {
            ai = new AI();
        }

        public ComputerPlayer(string dif)
        {
            ai = new AI(dif);
        }
    }
}
