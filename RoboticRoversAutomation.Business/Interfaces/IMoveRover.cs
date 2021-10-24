using System;
using System.Collections.Generic;
using System.Text;

namespace RoboticRoversAutomation.Interfaces
{
    public interface IMoveRover
    {
        void StartMoving(List<int> maxPoints, string moves);
    }
}
