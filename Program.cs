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
            Console.WriteLine("Finished creating player");
            AI computer = new AI();
            Console.WriteLine("Finished creating AI");

            player.board.lowerScreen.print();
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}
