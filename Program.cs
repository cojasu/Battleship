using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleshipTest.BoardData;

namespace BattleshipTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu m = new Menu();
            bool didSomeoneWin = false;
            m.Display();
            Player player = new Player();
            Console.WriteLine("Finished creating player");
            ComputerPlayer computer = new ComputerPlayer(m.difficulty);
            Console.WriteLine("Finished creating computer");
            player.board.upperScreen.screen = player.board.upperScreen.getUpperScreenFromOpponent(computer.board.lowerScreen);
            computer.board.upperScreen.screen = player.board.upperScreen.getUpperScreenFromOpponent(player.board.lowerScreen);

            //Main game loop
            while (didSomeoneWin == false)
            {
                if (m.humanGoesFirst == true)
                {
                    didSomeoneWin = player.turn();
                    if (didSomeoneWin == true)
                    {
                        Console.WriteLine("Congrats, you win");
                        break;
                    }
                    didSomeoneWin = computer.turn();
                    if (didSomeoneWin == true)
                    {
                        Console.WriteLine("Sorry, you lost");
                        break;
                    }
                }
                else
                {
                    didSomeoneWin = computer.turn();
                    if (didSomeoneWin == true)
                    {
                        Console.WriteLine("Sorry, you lost");
                        break;
                    }
                    didSomeoneWin = player.turn();
                    if (didSomeoneWin == true)
                    {
                        Console.WriteLine("Congrats, you win");
                        break;
                    }
                }
            }
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}
