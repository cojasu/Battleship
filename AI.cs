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
        bool lastShotHit;
        string direction;
        heatMap hm;
        public string difficulty;
        List<Coordinate> listOfPastShots = new List<Coordinate>();
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
            return null;
        }

        Coordinate hardMove()
        {
            return null;
        }

        Coordinate HuntShip()
        {
            direction = getDirection();
            return null;
        }

        Coordinate generateLegalRandomMove()
        {
            Coordinate temp = new Coordinate(listOfPastShots);
            return null;
        }

        string getDirection()
        {
            return null;
        }

    }
}
