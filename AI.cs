using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleshipTest.BoardData;

namespace BattleshipTest
{
    public class AI
    {
        public string difficulty;
        public AI()
        {

        }

        public AI(string dif)
        {
            difficulty = dif;
        }

        public Coordinate chooseMove()
        {
            //random
            if (difficulty == "easy")
            {
                return easyMove();
            }
            //hunting and targeting
            if (difficulty == "medium")
            {
                return mediumMove();
            }
            //Heat map
            else
            {
                return hardMove();
            }
        }


        Coordinate easyMove()
        {
            Coordinate tempCoord = new Coordinate();
            return tempCoord;
        }

        Coordinate mediumMove()
        {
            Coordinate tempCoord = new Coordinate();
            return tempCoord;
        }

        Coordinate hardMove()
        {
            Coordinate tempCoord = new Coordinate();
            return tempCoord;
        }
    }
}
