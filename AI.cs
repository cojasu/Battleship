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
        //variables for hunting and targetting
        Coordinate lastHit;
        bool isHunting = true;
        bool isLeftMiss;
        bool isRightMiss;
        bool isTopMiss;
        bool isBottomMiss;
        public string difficulty;
        public AI()
        {

        }

        public AI(string dif)
        {
            difficulty = dif;
        }

        public Coordinate chooseMove(Board oppB)
        {
            //random
            if (difficulty == "easy")
            {
                return easyMove();
            }
            //hunting and targeting
            if (difficulty == "medium")
            {
                return mediumMove(oppB);
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

        Coordinate mediumMove( Board oppB)
        {
            Coordinate tempCoord;
            if (isHunting)
            {
                tempCoord = HuntShip();
            }
            else
            {
                tempCoord = generateLegalRandomMove();
            }
            return tempCoord;
        }

        Coordinate hardMove()
        {
            Coordinate tempCoord = new Coordinate();
            return tempCoord;
        }

        Coordinate HuntShip()
        {
            return null;
        }

        Coordinate generateLegalRandomMove()
        {
            Coordinate tempCoord;
            return null;
        }
    }
}
