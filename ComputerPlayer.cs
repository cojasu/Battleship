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
        ComputerPlayer()
        {
            ai = new AI();
            board = new Board();
        }

        public ComputerPlayer(string dif)
        {
            ai = new AI(dif);
            board = new Board();
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
                return false;
            }
        }
        //Logic for taking computers turn. returns true if computer has won.
        public bool turn()
        {
            //Get coordinate for shot.
            Coordinate target = new Coordinate();
            do{
                target = ai.chooseMove();
            }while(!(isLegal(target)));
            
            //Take the Shot
            takeShot(target);

            //Check to see if won.
            return false;
        }
    }
}
