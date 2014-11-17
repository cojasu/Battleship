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
        public string item;

        public Coordinate(int x, int y, string item)
        {
            this.x = x;
            this.y = y;
            this.item = item;
        }

        public Coordinate(int x, int y){
            this.x = x;
            this.y = y;
        }
    }
}
