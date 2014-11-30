using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleshipTest.BoardData;

namespace BattleshipTest
{
    class PlayerManager
    {
        Player player;
        ComputerPlayer computerPlayer;

        public PlayerManager(bool dm)
        {
            player = new Player(dm);
            computerPlayer = new ComputerPlayer("easy", false);
            updateUpperScreens();
        }

        public PlayerManager(string dif, bool dm)
        {
            player = new Player(dm);
            computerPlayer = new ComputerPlayer(dif, dm);
            updateUpperScreens();
        }

        public void updateUpperScreens()
        {
            player.board.upperScreen.screen = player.board.upperScreen.getUpperScreenFromOpponent(computerPlayer.board.lowerScreen);
            computerPlayer.board.upperScreen.screen = player.board.upperScreen.getUpperScreenFromOpponent(player.board.lowerScreen);
        }
        public bool update(bool isHumanFirst, bool debugMode)
        {
            if (isHumanFirst)
            {
                player.turn(computerPlayer.board, debugMode);
                if (player.CheckWin(computerPlayer.board.lowerScreen.Ships))
                {
                    Console.WriteLine("Congratulations You Win");
                    return true;
                }
                computerPlayer.board.upperScreen.listofOpponentsSunkShips = player.board.lowerScreen.getListofDeadShips();
                computerPlayer.board.upperScreen.updateHeatMap(player.board.lowerScreen);
                computerPlayer.turn(player.board, debugMode);
                if (computerPlayer.CheckWin(player.board.lowerScreen.Ships))
                {
                    Console.WriteLine("The Computer wins");
                    return true;
                }
            }
            else
            {
                computerPlayer.board.upperScreen.listofOpponentsSunkShips = player.board.lowerScreen.getListofDeadShips();
                computerPlayer.board.upperScreen.updateHeatMap(player.board.lowerScreen);
                computerPlayer.turn(player.board, debugMode);
                computerPlayer.turn(player.board, debugMode);
                if (computerPlayer.CheckWin(player.board.lowerScreen.Ships))
                {
                    Console.WriteLine("The Computer wins");
                    return true;
                }
                player.turn(computerPlayer.board, debugMode);
                if (player.CheckWin(computerPlayer.board.lowerScreen.Ships))
                {
                    Console.WriteLine("Congratulations You Win");
                    return true;
                }
            }
            return false;
        }
    }
}
