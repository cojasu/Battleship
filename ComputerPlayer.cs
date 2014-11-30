using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleshipTest.BoardData;

namespace BattleshipTest
{
    class ComputerPlayer
    {
        public AI ai;
        public Board board;
        ComputerPlayer(bool dm)
        {
            ai = new AI();
            board = new Board(dm);
        }

        public ComputerPlayer(string dif, bool dm)
        {
            ai = new AI(dif, dm);
            board = new Board(dm);
        }

        public void takeShot(Coordinate target, Board oppb, bool debug){
            if (oppb.lowerScreen.screen[target.x, target.y].content != "#")
            {
                target.content = oppb.lowerScreen.screen[target.x, target.y].content;
                oppb.lowerScreen.screen[target.x, target.y].content = "H";
                board.upperScreen.hitOrMissScreen[target.x, target.y] = "H";
                Console.WriteLine("HIT");
            }
            else
            {
                oppb.lowerScreen.screen[target.x, target.y].content = "M";
                board.upperScreen.hitOrMissScreen[target.x, target.y] = "M";
                Console.WriteLine("MISS");
            }

            Console.WriteLine("Computer took shot at X: " + target.x + " Y: " + target.y);

            oppb.lowerScreen.Ships.ForEach(delegate(Ship ship)
            {
                if (ship.isHitDictionary.ContainsKey(target))
                {
                    ship.isHitDictionary[target] = true;
                }
            });
        }

        public bool isLegal(Coordinate target)
        {
            if (board.upperScreen.screen[target.x, target.y].content != "H")
            {
                if (board.upperScreen.screen[target.x, target.y].content != "M")
                {
                    return true;
                }
                return false;
            }
            else
            {
                return false;
            }
        }
        public bool CheckWin(List<Ship> s)
        {
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
        //Logic for taking computers turn. returns true if computer has won.
        public void turn(Board oppb, bool debug)
        {
            //Get coordinate for shot.
            Coordinate target = new Coordinate();
            do{
                target = ai.chooseMove(oppb, board.upperScreen.heatmap);
            }while(!(isLegal(target)));
            
            //Take the Shot
            takeShot(target, oppb, debug);
        }
    }
}
