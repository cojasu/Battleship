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
        public bool turn(Board oppBoard)
        {
            Coordinate tempCoord;
            printScreens();
            tempCoord = chooseMove();
            return false;
        }
        public void printScreens()
        {
            board.upperScreen.printHitOrMiss();
            Console.WriteLine("");
            board.lowerScreen.print();
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
