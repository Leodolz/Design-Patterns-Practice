﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class MoveUpwards : IMoveStrategy
    {
        public Point MovePosition(Point initialPosition)
        {
            initialPosition.Y = initialPosition.Y+1;
            return initialPosition;
        }
    }
}
