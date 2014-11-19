using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipTest
{
    public class Menu
    {
        public string difficulty;
        public bool humanGoesFirst;
        public bool debugMode;
        public Menu()
        {
            difficulty = "easy";
            humanGoesFirst = true;
            debugMode = false;
        }

        public Menu(string diff, bool hgf, bool dm)
        {
            difficulty = diff;
            humanGoesFirst = hgf;
            debugMode = dm;
        }

        public void Display()
        {
            bool validChoice = false;
            string ans = "";
            Console.WriteLine("Would you like to go first? y/n");
            do
            {
                ans = Console.ReadLine();
                if (ans == "y")
                {
                    validChoice = true;
                    humanGoesFirst = true;
                }
                if (ans == "n")
                {
                    validChoice = true;
                    humanGoesFirst = false;
                }
            } while (!validChoice);

            Console.WriteLine("Choose your difficulty level. 1 = Easy, 2 = Medium, 3 = Hard");
            validChoice = false;
            do
            {
                ans = Console.ReadLine();
                if (ans == "1")
                {
                    validChoice = true;
                    difficulty = "easy";
                }
                else if (ans == "2")
                {
                    validChoice = true;
                    difficulty = "medium";
                }
                else if (ans == "3")
                {
                    validChoice = true;
                    difficulty = "hard";
                }

            } while (!validChoice);

            Console.WriteLine("Do you want to turn Debug Mode on? y/n");
            validChoice = false;
            do
            {
                ans = Console.ReadLine();
                if (ans == "y")
                {
                    validChoice = true;
                    debugMode = true;
                }
                else if (ans == "n")
                {
                    validChoice = true;
                    debugMode = false;
                }
            } while (!validChoice);

        }
    }
}
