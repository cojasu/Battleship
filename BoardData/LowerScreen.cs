using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipTest.BoardData
{
    public class LowerScreen
    {
        Coordinate[,] screen = new Coordinate[10, 10];

        public LowerScreen()
        {
            for (int i = 0; i < screen.GetLength(0); i++)
            {
                for (int j = 0; j < screen.GetLength(1); j++)
                {
                    screen[i, j] = new Coordinate(i, j);
                }
            }

        }


        public void print()
        {
            for (int i = 0; i < screen.GetLength(0); i++)
            {
                for (int j = 0; j < screen.GetLength(1); j++)
                {
                    Console.Write("[" + screen[i, j].x + "][" + screen[i, j].y + "] ");
                }
                Console.WriteLine("");
            }
        }
    }
}




