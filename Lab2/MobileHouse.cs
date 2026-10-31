using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_OOP_basics
{
    public class MobileHouse : Building, Movable
    {
        public MobileHouse((int, int) coords) : base(coords)
        {
        }

        public override string getName()
        {
            return "MobileHouse";
        }

        public void moveTo((int, int) coords)
        {
            if (isBuilt())
            {
                _coords = coords;
            }
        }
    }
}
