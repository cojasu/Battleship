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

            Player player = new Player();
            Console.WriteLine("Finished creating player");
            ComputerPlayer computer = new ComputerPlayer(m.difficulty);
            Console.WriteLine("Finished creating computer");

            player.board.lowerScreen.print();
            player.board.lowerScreen.printShipData();
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}
