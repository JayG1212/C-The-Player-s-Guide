// Writtem by Jay Gunderson
// 07/14/2024
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Old_Robot__Polymorphism__Page_210_
{
    public class OnCommand : RobotCommand
    {
        public override void Run(Robot robot)
        {
            robot.IsPowered = true;
        }
    }
}
