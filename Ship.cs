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
        public int length;
        public string type;

        public Dictionary<Coordinate, bool> isHitDictionary = new Dictionary<Coordinate,bool>();

        public Ship(int length, string type)
        {
            this.length = length;
            this.type = type;
        }

        void addCoordinateToDictionary(int x, int y)
        {
            Coordinate temp = new Coordinate(x, y);
            isHitDictionary.Add(temp, false);
        }
    }
}
