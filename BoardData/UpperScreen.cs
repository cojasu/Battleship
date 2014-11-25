using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipTest.BoardData
{
    public class UpperScreen
    {
        public Coordinate[,] screen = new Coordinate[10, 10];
        public string[,] hitOrMissScreen = new string[10, 10];
        public Coordinate[,] heatmap = new Coordinate[10, 10];
        public List<Ship> listofOpponentsActiveShips = new List<Ship>();
        bool debugMode;

        public UpperScreen(bool dm)
        {
            debugMode = dm;
            for (int i = 0; i < screen.GetLength(0); i++)
            {
                for (int j = 0; j < screen.GetLength(1); j++)
                {
                    screen[i, j] = new Coordinate(i,j);
                    hitOrMissScreen[i, j] = "#";
                    heatmap[i, j] = new Coordinate(i, j);
                }
            }


        }

        public void printScreen()
        {
            for (int i = 0; i < screen.GetLength(0); i++)
            {
                for (int j = 0; j < screen.GetLength(1); j++)
                {
                    Console.Write("[" + screen[i, j].content + "] ");
                }
                Console.WriteLine("");
            }
        }
        public void printHitOrMiss()
        {
            for (int i = 0; i < screen.GetLength(0); i++)
            {
                for (int j = 0; j < screen.GetLength(1); j++)
                {
                    Console.Write("[" + hitOrMissScreen[i,j] +"] ");
                }
                Console.WriteLine("");
            }
        }
        
        public Coordinate[,] getUpperScreenFromOpponent(LowerScreen screen)
        {
            UpperScreen tempScreen = new UpperScreen(debugMode);
            for (int i = 0; i < tempScreen.screen.GetLength(0); i++)
            {
                for (int j = 0; j < tempScreen.screen.GetLength(1); j++)
                {
                        tempScreen.screen[i,j] = screen.screen[i,j];
                }
            }
            return tempScreen.screen;
        }

        #region Heatmap Stuff
        public void updateHeatMap(LowerScreen ls){
            getCounts(ls);
            printCounts();
            resetCounts();
        }

        void resetCounts()
        {

        }
        void getCounts(LowerScreen ls)
        {

                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        foreach (Ship ship in ls.Ships)
                        {
                            if (shipIsAlive(ship))
                            {
                                countShipFitHorizontal(ship, i, j);
                                countShipFitVertical(ship, i, j);
                            }
                        }
                    }
                }
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (hitOrMissScreen[i, j] == "H")
                        {
                            heatmap[i, j].count = 0;
                        }
                    }
                }
        }


        bool shipIsAlive(Ship ship)
        {
            foreach (KeyValuePair<Coordinate, bool> coord in ship.isHitDictionary)
            {
                if (coord.Value == false)
                {
                    return true;
                }
            }
            return false;
        }
        void countShipFitVertical(Ship ship, int x, int y)
        {
            for (int i = 0; i < ship.length; i++)
            {
                if (debugMode)
                {
                    Console.WriteLine("DEBUG INFO: On ShipVertical: " + ship.type + "X: " + x + "Y: " + y + "I: " + i);
                }
                if (y + i > 9)
                {
                    return;
                }
                else if (hitOrMissScreen[x, y + i] == "M")
                {
                    break;
                }
                if (hitOrMissScreen[x, y + i] == "H")
                {
                    if (y + i - 1 > -1)
                    {
                        heatmap[x, y + i - 1].count++;
                    }
                }
                if (!(y - i < 1))
                {
                    if (hitOrMissScreen[x, y - 1] == "H")
                    {
                        if (y + i + 1 < 10)
                        {
                            heatmap[x, y + i + 1].count++;
                        }
                    }
                }
            }
            for (int i = 0; i < ship.length; i++)
            {
                heatmap[x, y + i].count++;
            }
        }

        void countShipFitHorizontal(Ship ship, int x, int y)
        {
            for (int i = 0; i < ship.length; i++)
            {
                if (debugMode)
                {
                    Console.WriteLine("DEBUG INFO: On ShipVertical: " + ship.type + "X: " + x + "Y: " + y + "I: " + i);
                }
                if (x + i > 9)
                {
                    Console.WriteLine("Returning");
                    return;
                }
                else if (hitOrMissScreen[x + i, y] == "M")
                {
                    break;
                }
                if (hitOrMissScreen[x + i, y] == "H")
                {
                    if (x + i - 1 > -1)
                    {
                        heatmap[x + i - 1, y].count++;
                    }
                }
                if (!(x - i < 1))
                {
                    if (hitOrMissScreen[x - 1, y] == "H")
                    {
                        if (x + i + 1 < 10)
                        {
                            heatmap[x + i + 1, y].count++;
                        }
                    }
                }
            }
            for (int i = 0; i < ship.length; i++)
            {
                heatmap[x + i, y].count++;
            }
        }
        void printCounts()
        {
                for (int i = 0; i < heatmap.GetLength(0); i++)
                {
                    for (int j = 0; j < heatmap.GetLength(1); j++)
                    {
                        if (heatmap[i, j].count < 10)
                        {
                            Console.Write("[ " + heatmap[i, j].count + "] ");
                        }
                        else
                        {
                            Console.Write("[" + heatmap[i, j].count + "] ");
                        }
                    }
                    Console.WriteLine("");
                }
            
        }

        #endregion




    }
}
