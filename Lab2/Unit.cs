using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_OOP_basics
{
    public abstract class Unit : GameObject
    {
        private float _hp;
        public Unit((int, int) coords, float health) : base(coords)
        {
            _hp = health;
        }
        public bool isAlive()
        {
            return getHp() >0;
        }
        public float getHp()
        {
            return _hp;
        }
        public void recieveDamage(float damage)
        {
            _hp -= damage;
        }
    }
}
