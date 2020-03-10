using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class MoveRight:IMoveStrategy
    {
        public Point MovePosition(Point initialPosition)
        {
            initialPosition.X++;
            return initialPosition;
        }
    }
}
