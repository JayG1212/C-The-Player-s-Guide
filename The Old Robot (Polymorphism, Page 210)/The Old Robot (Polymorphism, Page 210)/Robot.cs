// Writtem by Jay Gunderson
// 07/14/2024
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace The_Old_Robot__Polymorphism__Page_210_
{
    public class Robot
    {
        private int x;
        private int y;

        public int X {
            get {return this.x; }
            set {this.x = value; } 
        }
        public int Y 
        {
             get{ return this.y;} 
             set{this.y = value; } 
        }
        public bool IsPowered { get; set; }
        public RobotCommand?[] Commands { get; } = new RobotCommand?[3];
        public void Run()
        {
            foreach (RobotCommand? command in Commands)
            {
                command?.Run(this);
                Console.WriteLine($"[{X} {Y} {IsPowered}]");
            }
        }
    }
}
