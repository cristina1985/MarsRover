using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MarsRover
{
    public class Orchastrator
    {
        public string[,] index = new string[15, 15];
        public void PrintInitialScreen()
        {
            Rover currentRover = new Rover(1, 1, Direction.North);
            Console.WriteLine("Please provide the rover coordinates separated by space \n [ the values shoud be between 0 and 14 ] :");
            string[] values = Console.ReadLine().Split(' ');
            currentRover.X = int.Parse(values[0]);
            currentRover.Y = int.Parse(values[1]);
            Console.WriteLine();
            Map map1 = new Map(currentRover.X, currentRover.Y, Direction.North);
            
        }    
        public void PrintMap(int k, int l, Direction direction)
        {
            Rover currentRover = new Rover(k, l, direction);
            Map map1 = new Map(k, l, direction);

        }


        public void ChangeOrientation(Direction direction)
        {
            Console.WriteLine("Please provide a direction for the rover {North,South,East,West} :");
            direction = Enum.Parse<Direction>(Console.ReadLine());   
            
        }


        public void MoveRover(int next_x, int next_y,Direction direction)
        {
            Rover nextRover = new Rover(next_x,next_y, direction);
            Map map2 = new Map(next_x, next_y, direction);

         }


       
    }
}
