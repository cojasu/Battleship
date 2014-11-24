using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipTest.BoardData
{
    class heatMap
    {
        public Coordinate[,] screen = new Coordinate[10, 10];

        public heatMap()
        {

        }

        void updateHeatMap(LowerScreen ls)
        {
            getCounts(ls);
            weightProbabilities();
        }

        void getCounts(LowerScreen ls)
        {
            foreach (Ship ship in ls.Ships){
                if (!isShipSunk(ship))
                {

                }
            }
        }

        void weightProbabilities()
        {

        }

        bool isShipSunk(Ship ship)
        {
            foreach(KeyValuePair<Coordinate, bool> coord in ship.isHitDictionary){
                if (coord.Value == false)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
