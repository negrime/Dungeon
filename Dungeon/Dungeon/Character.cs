using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    public struct Price
    {
        int chill;
        int slope;
        int fastSlope;
        int Ulta;

        public Price( int fs, int u)
        {
            chill = 0;
            slope = 5;
            fastSlope = fs;
            Ulta = u;
        }
    }
    abstract class Character
    {
        public  string name { get;  set; }
        public TypeOfAction action;
        public  Price actionPrice;
        private  int _stamina;
        public Point position;

        public  int Stamina
        {
            get
            {
                return _stamina;
            }

            set
            {
                    _stamina = value;
            }
        }

        public char sprite;

        public void Chill()
        {
            Stamina += 3;
        }
    }

    class Mage : Character
    {
        public Mage()
        {
            name = "Human";
            actionPrice = new Price(13, 15);
            Stamina = 30;
            sprite = '@';
        }

    }
}
