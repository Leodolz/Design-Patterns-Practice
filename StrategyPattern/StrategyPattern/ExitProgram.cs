using System;
using System.Drawing;

namespace StrategyPattern
{
    class ExitProgram : IMoveStrategy
    {
        public Point MovePosition(Point initialPosition)
        {
            Environment.Exit(0);
            return initialPosition;
        }
    }
}