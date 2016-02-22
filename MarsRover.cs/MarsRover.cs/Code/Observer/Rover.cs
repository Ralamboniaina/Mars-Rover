using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MarsRover.cs.Code.Subject;

namespace MarsRover.cs.Code.Observer
{
    public class Rover : Robot
    {
        public Rover() : base() { }
        public Rover(int x, int y, char direction, Society owner) : base(x, y, direction, owner)
        {
            
        }

        public void Rotate(char orientation)
        {
            if (orientation == Constants.RIGHT)
            {
                switch (Direction) 
                { 
                    case Constants.NORTH:
                        Direction = Constants.EAST;
                        break;
                    case Constants.EAST:
                        Direction = Constants.SOUTH;
                        break;
                    case Constants.SOUTH:
                        Direction = Constants.WEAST;
                        break;
                    case Constants.WEAST:
                        Direction = Constants.NORTH;
                        break;
                }
            }
            else
            {
                switch (Direction)
                {
                    case Constants.NORTH:
                        Direction = Constants.WEAST;
                        break;
                    case Constants.WEAST:
                        Direction = Constants.SOUTH;
                        break;
                    case Constants.SOUTH:
                        Direction = Constants.EAST;
                        break;
                    case Constants.EAST:
                        Direction = Constants.NORTH;
                        break;
                }
            }
        }

        public void ChangePosition()
        {
            switch (Direction)
            { 
                case Constants.NORTH:
                    Y++;
                    break;
                case Constants.EAST:
                    X++;
                    break;
                case Constants.SOUTH:
                    Y--;
                    break;
                case Constants.WEAST:
                    X--;
                    break;
            }
        }

        public override void Move(string mouvement)
        {
            foreach (char m in mouvement) 
            {
                switch (m) 
                {
                    case Constants.MOUVEMENT:
                        ChangePosition();
                        break;
                    default:
                        Rotate(m);
                        break;
                }
            }
        }

        public override void Land(string input)
        {
            string[] data = input.Split(' ');
            X = Int32.Parse(data[0]);
            Y = Int32.Parse(data[1]);
            Direction = data[2][0];
        }
    }
}