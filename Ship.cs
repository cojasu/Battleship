using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipTest
{
    class Ship
    {
        int length;
        string type;
        bool isSunk;
        int xCoord;
        int yCoord;

        Ship(int length, string type)
        {
            isSunk = false;
            this.length = length;
            this.type = type;
        }

        void setCoords(int x, int y)
        {
            xCoord = x;
            yCoord = y;
        }
    }
}
