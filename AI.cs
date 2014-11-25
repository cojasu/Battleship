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
            if (debugMode)
            {
                Console.WriteLine("Press Enter to Continue");
                Console.ReadLine();
            }
                Coordinate holdingCoord = new Coordinate();
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (debugMode == true)
                        {
                            Console.WriteLine("DEBUG INFO: heatmap[x,y]: " + heatmap[i, j].x + " " + heatmap[i, j].y + " " + heatmap[i, j].count);
                            Console.WriteLine("DEBUG INFO: holdingCoord: " + holdingCoord.x + " " + holdingCoord.y + " " + holdingCoord.count);
                        }
                        if (heatmap[i,j].count > holdingCoord.count)
                        {

                            if (debugMode == true)
                            {
                                Console.WriteLine("Probability changed.  Old: " + holdingCoord.count + "New " + heatmap[i, j].count);
                            }
                            holdingCoord.x = heatmap[i, j].x;
                            holdingCoord.y = heatmap[i, j].y;
                            holdingCoord.count = heatmap[i, j].count;
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
