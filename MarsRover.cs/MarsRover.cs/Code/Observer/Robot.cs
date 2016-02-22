using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MarsRover.cs.Code.Subject;

namespace MarsRover.cs.Code.Observer
{
    public abstract class Robot
    {
        private int x, y;
        private char direction;
        private Society owner;

        public Robot() { }

        public Robot(int x, int y, char direction, Society owner)
        {
            X = x;
            Y = x;
            Direction = direction;
            Owner = owner;
        }
        
        public int X
        {
            get{ return x; }
            set{ x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public char Direction
        {
            get { return direction; }
            set { direction = value; }
        }
        
        public Society Owner
        {
            get{ return owner; }
            set{ owner = value; }
        }

        public abstract void Move(string mouvement);

        public abstract void Land(string data);
    }
}
