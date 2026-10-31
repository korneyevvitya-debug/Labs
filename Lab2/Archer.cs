using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_OOP_basics
{
    public class Archer : Unit, Attacker, Movable
    {
        public Archer((int, int) coords, float health = 100) : base(coords, health)
        {

        }

        public void attack(Unit unit)
        {
            if (isAlive())
            {
                unit.recieveDamage(15);
            }
        }

        public override string getName()
        {
            return "Archer";
        }

        public void moveTo((int, int) coords)
        {
            if (!isAlive())
            {
                _coords = coords;
            }
        }
    }
}
