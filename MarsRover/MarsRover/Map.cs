using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    class Map : Rover
    {
        public int[,] index = new int[15, 15];
        public Map(int x, int y, Direction direction1)
        {
            X = x;
            Y = y;
            direction1 = direction;
            index[x, y] = direction;
            Console.WriteLine("The map is :");
            Console.WriteLine();
            int i, j;
            for (i = 0; i < 15; i++)
            {
                for (j = 0; j < 15; j++)
                {
                    // Console.Write("index[{0},{1}] = {2} ", i, j, index[i, j]);
                    Console.Write(index[i, j] + " ");

                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }

    }

}
