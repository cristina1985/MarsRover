using System;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {

            Orchastrator orchastrator = new Orchastrator();
            orchastrator.PrintInitialScreen();           
            Console.WriteLine();
            //orchastrator.PrintMap(currentRover.X, currentRover.Y,currentRover.direction);            
            //Console.WriteLine("Please provide a direction for the rover {North,South,East,West} :");
            //currentRover.direction = Enum.Parse<Direction>(Console.ReadLine());
            // orchastrator.ChangeOrientation(Direction.West);
            orchastrator.MoveRover(3, 2, Direction.South);
           
            //Console.WriteLine($"{currentRover.direction}");
            //Console.WriteLine($"The new rover position is {currentRover.X} and {currentRover.Y}");
            //Map map2 = new Map(currentRover.X, currentRover.Y,currentRover.direction);

                      
            Console.ReadLine();
        }
    }
}