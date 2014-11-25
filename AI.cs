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
        string direction;
        public string difficulty;
        bool debugMode;
        List<Coordinate> listOfPastShots = new List<Coordinate>();
        public AI()
        {

        }

        public AI(string dif, bool dm)
        {
            difficulty = dif;
            debugMode = dm;
        }

        public Coordinate chooseMove(Board oppB, Coordinate[,] heatmap)
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
                return hardMove(oppB, heatmap);
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

        Coordinate hardMove(Board oppB, Coordinate[,] heatmap)
        {
                Coordinate holdingCoord = new Coordinate();
                for (int x = 0; x < 10; x++)
                {
                    for (int y = 0; y < 10; y++)
                    {
                        if (heatmap[x,y].count > holdingCoord.count)
                        {
                            holdingCoord.x = heatmap[x, y].x;
                            holdingCoord.y = heatmap[x, y].y;
                            holdingCoord.count = heatmap[x, y].count;
                        }
                    }
                }
                return holdingCoord; 
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
