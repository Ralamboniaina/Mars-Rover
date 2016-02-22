using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MarsRover.cs.Code.Observer;
using MarsRover.cs.Code.Subject;
using System.IO;

namespace MarsRover.cs
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var path = Server.MapPath("~") + "Files\\Input.txt";
            string[] inputs = File.ReadAllLines(path);

            Society nasa = new Society("NASA");

            Rover r1 = new Rover();
            r1.Land(inputs[1]);
            r1.Owner = nasa;

            Rover r2 = new Rover();
            r2.Land(inputs[3]);
            r2.Owner = nasa;

            nasa.NotifyRobot(r1, inputs[2]);
            nasa.NotifyRobot(r2, inputs[4]);

            output1.InnerText = r1.X + " " + r1.Y + " " + r1.Direction;
            output2.InnerText = r2.X + " " + r2.Y + " " + r2.Direction;
        }
    }
}