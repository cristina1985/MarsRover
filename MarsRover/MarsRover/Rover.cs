using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public class Rover
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Direction direction { get; set; }

        public Rover(int x, int y, Direction direction1)
        {
            X = x;
            Y = y;
            direction = direction1;
        }

        public void ChangeOrientation(Direction direction)
        {
            switch (direction)
            {
                case Direction.N:
                    if (X - 1 >= 0)
                        X -= 1;
                    else Console.WriteLine("The rover can't move to this direction");
                    break;
                case Direction.E:
                    if (Y + 1 <= 15)
                        Y += 1;
                    else Console.WriteLine("The rover can't move to this direction");
                    break;
                case Direction.S:
                    if (X + 1 <= 15)
                        X += 1;
                    else Console.WriteLine("The rover can't move to this direction");
                    break;
                case Direction.W:
                    if (Y - 1 >= 0)
                        Y -= 1;
                    else Console.WriteLine("The rover can't move to this direction");
                    break;
                default: throw new ArgumentOutOfRangeException();
            }
        }

    } 
}
