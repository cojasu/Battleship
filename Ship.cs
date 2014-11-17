using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleshipTest.BoardData;

namespace BattleshipTest
{
    class Ship
    {
        int length;
        string type;
        bool isSunk;
        List<Coordinate> coords = new List<Coordinate>();
        Ship(int length, string type)
        {
            isSunk = false;
            this.length = length;
            this.type = type;
        }

        void addCoordinate(int x, int y)
        {
            Coordinate tempCoord = new Coordinate(x, y);
            coords.Add(tempCoord);
        }
    }
}
