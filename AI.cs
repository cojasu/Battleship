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
                return hardMove(oppB);
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

        Coordinate hardMove(Board oppB)
        {
                Coordinate holdingCoord = new Coordinate();
                for (int x = 0; x < 10; x++)
                {
                    for (int y = 0; y < 10; y++)
                    {
                        if (debugMode == true)
                        {
                            Console.WriteLine("DEBUG INFO: heatmap[x,y]: " + oppB.upperScreen.heatmap[x, y].x + " " + oppB.upperScreen.heatmap[x, y].y + " " + oppB.upperScreen.heatmap[x, y].count);
                            Console.WriteLine("DEBUG INFO: holdingCoord: " + holdingCoord.x + " " + holdingCoord.y + " " + holdingCoord.count);
                        }
                        if (oppB.upperScreen.heatmap[x,y].probability > holdingCoord.probability)
                        {

                            if (debugMode == true)
                            {

                                Console.WriteLine("Probability changed.  Old: " + holdingCoord.probability + "New " + oppB.upperScreen.heatmap[x, y].probability);
                            }
                            holdingCoord = oppB.upperScreen.heatmap[x, y];
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
