using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipTest.BoardData
{
    public class UpperScreen
    {
        public Coordinate[,] screen = new Coordinate[10, 10];
        public string[,] hitOrMissScreen = new string[10, 10];

        public UpperScreen()
        {
            for (int i = 0; i < screen.GetLength(0); i++)
            {
                for (int j = 0; j < screen.GetLength(1); j++)
                {
                    screen[i, j] = new Coordinate(i,j);
                    hitOrMissScreen[i, j] = "#";
                }
            }

        }

        public void printScreen()
        {
            for (int i = 0; i < screen.GetLength(0); i++)
            {
                for (int j = 0; j < screen.GetLength(1); j++)
                {
                    Console.Write("[" + screen[i, j].content + "] ");
                }
                Console.WriteLine("");
            }
        }
        public void printHitOrMiss()
        {
            for (int i = 0; i < screen.GetLength(0); i++)
            {
                for (int j = 0; j < screen.GetLength(1); j++)
                {
                    Console.Write("[" + hitOrMissScreen[i,j] +"] ");
                }
                Console.WriteLine("");
            }
        }
        
        public Coordinate[,] getUpperScreenFromOpponent(LowerScreen screen){
            UpperScreen tempScreen = new UpperScreen();
            for (int i = 0; i < tempScreen.screen.GetLength(0); i++)
            {
                for (int j = 0; j < tempScreen.screen.GetLength(1); j++)
                {
                        tempScreen.screen[i,j] = screen.screen[i,j];
                }
            }
            return tempScreen.screen;
        }
    }
}
