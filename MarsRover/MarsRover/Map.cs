using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public class Map 
    {
        public string[,] index = new string[15, 15];
        public Map(int k, int l, Direction direction)
        {
            Console.WriteLine("The map is :");
            Console.WriteLine();
            int i, j;
            for (i = 0; i < 15; i++)
            {
                for (j = 0; j < 15; j++)
                {
                    if ((i != k) || (j != l))
                    {
                        index[i, j] = 0.ToString();
                    }
                    else
                    {
                        switch (direction)
                        {
                            case Direction.E:
                                index[i, j] = Char.ConvertFromUtf32(0x2192);
                                break;

                            case Direction.N:
                                index[i, j] = Char.ConvertFromUtf32(0x2191);
                                break;
                            case Direction.S:
                                index[i, j] = Char.ConvertFromUtf32(0x2193);
                                break;
                            case Direction.W:
                                index[i, j] = Char.ConvertFromUtf32(0x2190);
                                break;
                            default: throw new ArgumentOutOfRangeException();
                        }
                    }
                    // Console.Write("index[{0},{1}] = {2} ", i, j, index[i, j]);
                    Console.Write(index[i, j] + " ");

                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        } 

    }

}
