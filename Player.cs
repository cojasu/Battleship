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
        public bool turn(Board oppBoard, bool debugMode)
        {
            Coordinate target;
            printScreens(oppBoard, debugMode);
            target = chooseMove();
            TakeShot(oppBoard, target, debugMode);
            return false;
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
                    Console.WriteLine("DEBUG INFO: On Ship " + ship.type + " : Target " + target.x + "" + target.y + "" + target.content);
                    
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
        public Coordinate chooseMove()
        {
            int xCoord;
            int yCoord;
            string input = "";
            bool legalCoord = false;
            Coordinate tempCoord;
            Console.WriteLine("Enter your x Coordinate (0 - 9)");
            do
            {
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

                tempCoord = new Coordinate(yCoord, xCoord);
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
