using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleshipTest.BoardData;

namespace BattleshipTest
{
    public class Player
    {
        public Board board;

        public Player()
        {
            board = new Board();
        }
        //Logic for players turn, return true if player has won.
        public void turn(Board oppBoard, bool debugMode)
        {
            Coordinate target;
            printScreens(oppBoard, debugMode);
            target = chooseMove();
            TakeShot(oppBoard, target, debugMode);
        }

        public void TakeShot(Board oppB, Coordinate target, bool debug)
        {
            //Update boards
            if (oppB.lowerScreen.screen[target.x, target.y].content != "#")
            {
                target.content = oppB.lowerScreen.screen[target.x, target.y].content;
                oppB.lowerScreen.screen[target.x, target.y].content = "H";
                board.upperScreen.hitOrMissScreen[target.x, target.y] = "H";
            }
            else
            {
                oppB.lowerScreen.screen[target.x, target.y].content = "M";
                board.upperScreen.hitOrMissScreen[target.x, target.y] = "M";
            }

            //Update opponent's ShipData

            oppB.lowerScreen.Ships.ForEach(delegate(Ship ship)
            {
                if (debug == true)
                {
                    Console.WriteLine("DEBUG INFO: On Ship " + ship.type + " : Target X: " + target.x + " Target Y: " + target.y + " Target Content: " + target.content);
                    foreach (Coordinate coord in ship.isHitDictionary.Keys)
                    {
                        Console.WriteLine("DEBUG INFO: CoordKey X: " + coord.x + " Y: " + coord.y + " Content: " + coord.content);
                    }
                }
                if (ship.isHitDictionary.ContainsKey(target))
                {
                    if (debug == true)
                    {
                        Console.WriteLine("DEBUG INFO: ship.IsHitDictionary.ContainsKey(target) is true");
                    }
                    ship.isHitDictionary[target] = true;
                }
            });
        }
        public void printScreens(Board oppB, bool dm)
        {
            board.upperScreen.printHitOrMiss();
            Console.WriteLine("");
            board.lowerScreen.print();
            if (dm == true)
            {
                Console.WriteLine("=========Debug Information========");
                Console.WriteLine("Opponent Lower Board");
                oppB.lowerScreen.print();
                Console.WriteLine("");
                Console.WriteLine("Opponent Ship Data");
                oppB.lowerScreen.printShipData(dm);
                Console.WriteLine("");
            }
        }

        public bool CheckWin(List<Ship> s){
            bool didWin = true;
            s.ForEach(delegate(Ship ship)
            {
                foreach (KeyValuePair<Coordinate, bool> coord in ship.isHitDictionary)
                {
                    if (coord.Value == false)
                    {
                        didWin = false;
                        break;
                    }
                }
            });

            return didWin;
        }
        public Coordinate chooseMove()
        {
            int xCoord;
            int yCoord;
            string input = "";
            bool legalCoord = false;
            Coordinate tempCoord;
            do
            {
                Console.WriteLine("Enter your x Coordinate (0 - 9)");
                do
                {
                    do
                    {
                        input = Console.ReadLine();
                        legalCoord = Int32.TryParse(input, out xCoord);
                    } while (!legalCoord);
                    legalCoord = false;
                    if (xCoord < 10)
                    {
                        if (xCoord > -1)
                        {
                            legalCoord = true;
                        }
                    }
                } while (!legalCoord);
                legalCoord = false;
                Console.WriteLine("Enter your y Coordinate (0 - 9)");
                do
                {
                    do
                    {
                        input = Console.ReadLine();
                        legalCoord = Int32.TryParse(input, out yCoord);
                    } while (!legalCoord);
                    legalCoord = false;
                    if (yCoord < 10)
                    {
                        if (yCoord > -1)
                        {
                            legalCoord = true;
                        }
                    }
                } while (!legalCoord);

                tempCoord = new Coordinate(xCoord, yCoord);
                if (board.upperScreen.hitOrMissScreen[tempCoord.x, tempCoord.y] == "#")
                {
                    legalCoord = true;
                }
                else
                {
                    Console.WriteLine("Shot already has been taken");
                    legalCoord = false;
                }
            } while (!legalCoord);
            return tempCoord;
        }
    }
}
