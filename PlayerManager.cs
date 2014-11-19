﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipTest
{
    class PlayerManager
    {
        Player player;
        ComputerPlayer computerPlayer;

        public PlayerManager()
        {
            player = new Player();
            computerPlayer = new ComputerPlayer("easy");
            updateUpperScreens();
        }

        public PlayerManager(string dif)
        {
            player = new Player();
            computerPlayer = new ComputerPlayer(dif);
            updateUpperScreens();
        }

        public void updateUpperScreens()
        {
            player.board.upperScreen.screen = player.board.upperScreen.getUpperScreenFromOpponent(computerPlayer.board.lowerScreen);
            computerPlayer.board.upperScreen.screen = player.board.upperScreen.getUpperScreenFromOpponent(player.board.lowerScreen);
        }
        public void update(bool isHumanFirst)
        {
            if (isHumanFirst)
            {
                player.turn();
                computerPlayer.turn();
            }
            else
            {
                computerPlayer.turn();
                player.turn();
            }
        }
    }
}