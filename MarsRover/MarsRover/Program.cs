using System;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            int[ , ] index = new int[15,15] ;
            Rover currentRover = new Rover(1, 1, Direction.N);
           // Console.WriteLine("Please provide the rover first coordinate between 0 and 14 :");
            //currentRover.X = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please provide the rover second coordinate between 0 and 14 :");
            //currentRover.Y = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            
            Console.WriteLine("Please provide a direction for the rover {N,S,E,W} :");
            //currentRover.Direction = currentRover.ToString(Console.ReadLine());
            index[0, 0] = 5;
            Console.WriteLine("The map is :");
            Console.WriteLine();
            int i, j;
            for (i=0; i<15; i++)
            {
                for (j=0; j<15; j++)
                {
                    // Console.Write("index[{0},{1}] = {2} ", i, j, index[i, j]);
                    Console.Write(index[i, j] + " ");
                  
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
            Console.ReadLine();
            
        }
    }
}
