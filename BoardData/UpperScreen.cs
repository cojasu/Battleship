using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipTest.BoardData
{
    public class UpperScreen
    {
        int[,] screen = new int[10, 10];

        public UpperScreen()
        {
            for (int i = 0; i < screen.GetLength(0); i++)
            {
                for (int j = 0; j < screen.GetLength(1); j++)
                {
                    screen[i, j] = 0;
                }
            }

        }

        public void printExtended()
        {
            for (int i = 0; i < screen.GetLength(0); i++)
            {
                for (int j = 0; j < screen.GetLength(1); j++)
                {
                    Console.Write("upperPlayScreen: [" + i + "][" + j + "]: " + numToString(screen[i, j]) + " ");
                }
                Console.WriteLine("");
            }
        }

        public void printSimple()
        {
            for (int i = 0; i < screen.GetLength(0); i++)
            {
                for (int j = 0; j < screen.GetLength(1); j++)
                {
                    Console.Write(numToString(screen[i, j]) + " " );
                }
                Console.WriteLine("");
            }
        }

        public string numToString(int num)
        {
            if (num == 0)
            {
                //no data
                return "ND";
            }
            if (num == 1)
            {
                //hit
                return "H";
            }
            if (num == 2)
            {
                //miss
                return "M";
            }
            else
            {
                //error
                return "E";
            }
        }
    }
}
