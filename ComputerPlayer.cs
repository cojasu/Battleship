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

        public void takeShot(Coordinate coord){

        }

        public bool isLegal(Coordinate target)
        {
            if (board.upperScreen.screen[target.x, target.y].content == "#")
            {

                return true;
            }
            else
            {
                Console.WriteLine("Target not legal");
                return false;
            }
        }
        //Logic for taking computers turn. returns true if computer has won.
        public bool turn(Board oppb, bool debug)
        {
            //Get coordinate for shot.
            Coordinate target = new Coordinate();
            do{
                target = ai.chooseMove(oppb, board.upperScreen.heatmap);
            }while(!(isLegal(target)));
            
            //Take the Shot
            takeShot(target);

            //Check to see if won.
            return false;
        }
    }
}
