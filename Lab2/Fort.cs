using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_OOP_basics
{
    public class Fort : Building, Attacker
    {
        public Fort((int, int) coords) : base(coords)
        {
        }

        public void attack(Unit unit)
        {
            if (isBuilt())
            {
                unit.recieveDamage(25);
            }
        }

        public override string getName()
        {
            return "Fort";
        }
    }
}
