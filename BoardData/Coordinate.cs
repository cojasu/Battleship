using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipTest.BoardData
{
    public class Coordinate
    {
        public int x;
        public int y;
        public string content;

        public Coordinate(int x, int y)
        {
            this.x = x;
            this.y = y;
            content = "#";
        }

        public Coordinate()
        {
            this.x = generateRandom();
            this.y = generateRandom();
            content = "#";
        }

        int generateRandom()
        {
            Random rnd = new Random();
            return rnd.Next(10);
        }

    }
}
