using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_OOP_basics
{
    public abstract class Building : GameObject
    {
        private float _buldingProgress;
        public Building((int, int) coords) : base(coords)
        {
            _buldingProgress = 0;
        }
        public bool isBuilt()
        {
            return _buldingProgress >= 100;
        }
        public void addProgress(float progress)
        {
            _buldingProgress += progress;
        }
    }
}
