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
            m.Display();
            PlayerManager playerManager = new PlayerManager(m.difficulty);

            bool didSomeoneWin = false;
            //Main game loop
            while (didSomeoneWin == false)
            {
                playerManager.update(m.humanGoesFirst);
            }
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}
