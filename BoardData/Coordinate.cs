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

        public Coordinate(int x, int y, string con)
        {
            this.x = x;
            this.y = y;
            content = con;
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

    public class CoordinateEqualityComparer : IEqualityComparer<Coordinate>
    {
        public bool Equals(Coordinate x, Coordinate y)
        {
            return ((x.x == y.x) & (x.y == y.y) & (x.content == y.content));
            }

        public int GetHashCode(Coordinate obj)
        {
            string combined = obj.x.ToString() + "|" + obj.y.ToString() + "|" + obj.content.ToString();
            return (combined.GetHashCode());
        }
    }
}
