using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    interface IMoveStrategy
    {
        Point MovePosition(Point initialPosition);
    }
}
