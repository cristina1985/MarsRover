using System;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            Rover currentRover = new Rover(1, 1, Direction.N);
            Console.WriteLine("Please provide the rover first coordinate between 0 and 14 :");
            currentRover.X = int.Parse(Console.ReadLine());
            Console.WriteLine("Please provide the rover second coordinate between 0 and 14 :");
            currentRover.Y = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Map map1 = new Map(currentRover.X, currentRover.Y,currentRover.direction);

            //index[currentRover.X, currentRover.Y] = 5;
            Console.WriteLine("Please provide a direction for the rover {N,S,E,W} :");
            currentRover.direction = Enum.Parse<Direction>(Console.ReadLine());
            currentRover.ChangeOrientation(currentRover.direction);
            //Console.WriteLine($"{currentRover.direction}");
            Console.WriteLine($"The new rover position is {currentRover.X} and {currentRover.Y}");
            Console.ReadLine();
            Map map2 = new Map(currentRover.X, currentRover.Y,currentRover.direction);

                      
            Console.ReadLine();
        }
    }
}