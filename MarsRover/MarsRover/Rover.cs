using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public class Rover
    {
        

        public Rover(int x, int y, Direction direction)
        {
            X = x;
            Y = y;
            Direction = direction;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public int nextX { get; set; }
        public int nextY { get; set; }

        public Direction Direction { get; set; }

        //public bool Move(x, y)
        //public bool Rotate(orientation)

    }
}
        

       /* public void ChangeOrientation(Direction direction)
        {
            switch (direction)
            {
                case Direction.North:
                    if (X - 1 >= 0)
                        X -= 1;
                    else Console.WriteLine("The rover can't move to this direction");
                    break;
                case Direction.East:
                    if (Y + 1 <= 14)
                        Y += 1;
                    else Console.WriteLine("The rover can't move to this direction");
                    break;
                case Direction.South:
                    if (X + 1 <= 14)
                        X += 1;
                    else Console.WriteLine("The rover can't move to this direction");
                    break;
                case Direction.West:
                    if (Y - 1 >= 0)
                        Y -= 1;
                    else Console.WriteLine("The rover can't move to this direction");
                    break;
                default: throw new ArgumentOutOfRangeException();
            }
        }

    */


