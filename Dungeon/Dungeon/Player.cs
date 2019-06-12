using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    public struct Point
    {
       public int x;
       public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    public enum TypeOfAction { chill, slope, fastSlope, Ulta}
    class Player
    {
        public string name;
        public Character character;
       
        

       
    }               
}
