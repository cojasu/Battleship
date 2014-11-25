using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipTest.BoardData
{
    public class LowerScreen
    {
        public Coordinate[,] screen = new Coordinate[10, 10];

        public List<Ship> Ships = new List<Ship>();
        public bool debugMode;
        public LowerScreen(bool dm)
        {
            debugMode = dm;
            for (int i = 0; i < screen.GetLength(0); i++)
            {
                for (int j = 0; j < screen.GetLength(1); j++)
                {
                    screen[i, j] = new Coordinate(i, j);
                }
            }

            Ship carrier = new Ship(5, "c");
            Ship battleship = new Ship(4, "b");
            Ship submarine = new Ship(3, "s");
            Ship destroyer = new Ship(3, "d");
            Ship boat = new Ship(2, "o");

            Ships.Add(carrier);
            Ships.Add(battleship);
            Ships.Add(submarine);
            Ships.Add(destroyer);
            Ships.Add(boat);
            initializeShipData();

        }

        void initializeShipData()
        {
            Random rnd = new Random();
            Ships.ForEach(delegate(Ship ship)
            {
                bool spotFound = false;

                do
                {
                    bool addingFlag = true;
                    Coordinate temp = new Coordinate();
                    if (screen[temp.x, temp.y].content == "#")
                    {
                        //generate direction
                        //horizontal
                        int dir = rnd.Next(2);
                        if (dir == 0)
                        {
                            for (int x = 0; x < ship.length; x++)
                            {
                                if (temp.x < 10 && (temp.y + x) < 10)
                                {
                                    if (!(screen[temp.x, temp.y + x].content == "#"))
                                    {
                                        addingFlag = false;
                                    }
                                }
                                else
                                {
                                    addingFlag = false;
                                }
                            }
                            if (addingFlag)
                            {
                                for (int x = 0; x < ship.length; x++)
                                {
                                    screen[temp.x, temp.y + x].content = ship.type;
                                    Coordinate dictTempCoord = new Coordinate(temp.x, temp.y + x, ship.type);
                                    ship.isHitDictionary.Add(dictTempCoord, false);
                                }
                                spotFound = true;
                            }
                        }
                        //Vertical
                        else
                        {
                            for (int x = 0; x < ship.length; x++)
                            {

                                if ((temp.x + x) < 10 && temp.y < 10)
                                {
                                    if ((!(screen[temp.x + x, temp.y].content == "#")))
                                    {
                                        addingFlag = false;
                                    }
                                }
                                else
                                {
                                    addingFlag = false;
                                }
                            }
                            if (addingFlag)
                            {
                                for (int x = 0; x < ship.length; x++)
                                {
                                    screen[temp.x + x, temp.y].content = ship.type;
                                    Coordinate dictTempCoord = new Coordinate(temp.x + x, temp.y, ship.type);
                                    ship.isHitDictionary.Add(dictTempCoord, false);
                                }
                                spotFound = true;
                            }
                        }
                    }

                }while(!spotFound);
            });
        }

        public void print()
        {
            for (int i = 0; i < screen.GetLength(0); i++)
            {
                for (int j = 0; j < screen.GetLength(1); j++)
                {
                    Console.Write("[" + screen[j,i].content + "] ");
                }
                Console.WriteLine("");
            }
        }
        
        public void printShipData(bool debug)
        {
            Ships.ForEach(delegate(Ship ship)
            {
                Console.WriteLine(ship.type);
                foreach (KeyValuePair<Coordinate, bool> coord in ship.isHitDictionary)
                {
                    if (debug == true)
                    {
                        Console.WriteLine("Coordinate " + coord.Key.x + ":" + coord.Key.y + " Is Hit? " + coord.Value + " Content: " + coord.Key.content);                      
                    }
                }
            });
        }
    }
}




