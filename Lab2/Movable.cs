using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_OOP_basics
{
    public interface Movable
    {
        void moveTo((int, int) coords);
    }
}
