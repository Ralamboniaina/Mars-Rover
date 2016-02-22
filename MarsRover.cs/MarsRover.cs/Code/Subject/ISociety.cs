using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MarsRover.cs.Code.Observer;

namespace MarsRover.cs.Code.Subject
{
    interface ISociety
    {
        void NotifyRobot(Robot aRobot, String mouvements);
    }
}
