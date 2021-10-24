﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RoboticRoversAutomation.Domain.Structs
{
    public struct Point
    {
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X { get; }
        public int Y { get; }
    }
}
