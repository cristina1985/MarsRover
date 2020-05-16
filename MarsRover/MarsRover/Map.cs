using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public class Map 
    {
        public int[,] index = new int[15, 15];
        public Map(int k, int l, Direction direction)
        {
            /* if (direction  == Direction.E)
             {
               index[k, l] = Char.ConvertFromUtf32(0x2192);

             }  */
            index[k,l]=5;
           // string s = Convert.ToString(index[k, l]);
            //index[k,l]= index[k,l] + Char.ConvertFromUtf32(0x2192);
            //index[k, l] = Char.ConvertFromUtf32(0x2192);
    
            //Console.WriteLine($"Value s is {s}");
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
