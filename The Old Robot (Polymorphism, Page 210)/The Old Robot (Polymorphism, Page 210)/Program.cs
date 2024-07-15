// Writtem by Jay Gunderson
// 07/14/2024
namespace The_Old_Robot__Polymorphism__Page_210_
{
    public class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot();
            for (int index = 0; index < robot.Commands.Length; index++)
                {
                Console.Write("Input command (on, off, north, south, east, west): ");
                string? input = Console.ReadLine();
                RobotCommand newCommand = input switch
                {
                    "on" => new OnCommand(),
                    "off" => new OffCommand(),
                    "north" => new NorthCommand(),
                    "south" => new SouthCommand(),
                    "east" => new EastCommand(),
                    "west" => new WestCommand(),
                };
                robot.Commands[index] = newCommand;
                }

            Console.WriteLine();
            robot.Run();
        }
    }
}
