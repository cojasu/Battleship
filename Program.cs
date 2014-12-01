using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleshipTest.BoardData;
using System.Windows.Forms;

namespace BattleshipTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu m = new Menu();
            Game myGame = new Game();
            Application.Run(myGame);
            if (m.demoMode)
            {
                List<demoManager> listdm = new List<demoManager>();
                Console.Write("How many games do you want to get stats on?");
                string numOfGames = Console.ReadLine();
                int num = Convert.ToInt32(numOfGames);
                List<int> turnGameEnded = new List<int>();
                bool didSomeoneWin = false;

                    for (int x = 0; x < num; x++)
                    {
                        listdm.Add(new demoManager());
                    }
                    foreach (demoManager dm in listdm)
                    {
                        didSomeoneWin = false;
                        int turnCount = 0;
                  
                        while (didSomeoneWin == false)
                        {
                            turnCount++;
              
                            didSomeoneWin = dm.update();
                        }
                        turnGameEnded.Add(turnCount);
                    }
                    Statistics stats = new Statistics(turnGameEnded);
                }
            else
            {
                PlayerManager playerManager = new PlayerManager(m.difficulty, m.debugMode);
                bool didSomeoneWin = false;
                int turnCount = 0;
                //Main game loop
                while (didSomeoneWin == false)
                {
                    turnCount++;
                    Console.WriteLine("On Turn: " + turnCount);
                    didSomeoneWin = playerManager.update(m.humanGoesFirst, m.debugMode);

                }
            }
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();

        }
    }
}
