using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipTest
{
    class ComputerPlayer
    {
        public AI ai;
        ComputerPlayer()
        {
            ai = new AI();
        }

        public ComputerPlayer(string dif)
        {
            ai = new AI(dif);
        }
        //Logic for taking computers turn. returns true if computer has won.
        public bool turn()
        {
            return false;
        }
    }
}
