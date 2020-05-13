using System;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            int[ , ] index = new int[15,15] ;
            Console.WriteLine("Please provide the rover first coordinate ( must be <=15 ) :");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Please provide the rover second coordinate ( must be <=15 ) :");
            int y = int.Parse(Console.ReadLine());
            index[x, y] = 5;
            int i, j;
            for (i=0; i<15; i++)
            {
                for (j=0; j<15; j++)
                {
                    Console.WriteLine("index[{0},{1}] = {2}",i,j, index[i, j]);
                }
                
            }
            
            
        }
    }
}
