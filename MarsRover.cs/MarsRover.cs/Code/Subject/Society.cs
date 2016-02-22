using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MarsRover.cs.Code.Observer;

namespace MarsRover.cs.Code.Subject
{
    public class Society : ISociety
    {
        private string name;
        private List<Rover> robotList;

        public Society(string name)
        {
            Name = name;
            robotList = new List<Rover>();
        }

        public string Name
        {
            get{ return name; }
            set{ name = value; }
        }

        public void AttachRobot(Rover aRover) 
        {
            robotList.Add(aRover);
        }

        public void DetachRobot(Rover aRover)
        {
            robotList.Add(aRover);
        }

        public void NotifyRobot(Robot aRobot, String mouvements)
        {
            aRobot.Move(mouvements);
        }
    } 
}