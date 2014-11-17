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

            Player player = new Player();
            AI computer = new AI();

            player.board.upperScreen.print();
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}
