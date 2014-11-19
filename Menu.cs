using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipTest
{
    class Menu
    {
        string difficulty;
        bool humanGoesFirst;
        Menu()
        {
            difficulty = "easy";
            humanGoesFirst = true;
        }

        Menu(string diff, bool hgf)
        {
            difficulty = diff;
            humanGoesFirst = hgf;
        }

        public void Display()
        {
            string ans = "";
            Console.WriteLine("Would you like to go first? y/n");
            do
            {
                ans = Console.ReadLine();
            } while (ans != "y" || ans != "n");
            if (ans == "y")
            {
                humanGoesFirst = true;
            }
            else
            {
                humanGoesFirst = false;
            }

            Console.WriteLine("Choose your difficulty level. 1 = Easy, 2 = Medium, 3 = Hard");
            do
            {
                ans = Console.ReadLine();
            } while (ans != "1" || ans != "2" || ans != "3");
            if (ans == "1")
            {
                difficulty = "easy";
            }
            else if (ans == "2")
            {
                difficulty = "medium";
            }
            else
            {
                difficulty = "hard";
            }
        }
    }
}
