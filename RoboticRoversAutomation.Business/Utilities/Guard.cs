using RoboticRoversAutomation.Business.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoboticRoversAutomation.Business.Utilities
{
    public class Guard
    {
        public static bool IsInsideBoundary(List<int> maxCoordinates,int startingPointX,int startingPointY)
        {
            if (startingPointX < 0 || startingPointX > maxCoordinates[0] || startingPointY < 0 || startingPointY > maxCoordinates[1])
            {
                return false;
            }
            return true;
        }
    }
}
