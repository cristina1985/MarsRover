using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public class Rover
    {
        public int X { get; set; }
        public int Y { get; set; }

        public int next_x { get; set; }
        public int next_y { get; set; }
       
        public Direction direction { get; set; }

        public Rover(int x, int y, Direction direction1)
        {
            X = x;
            Y = y;
            direction = direction1;
        }
        
        public void InitialPosition()
        {
            X = Y = 0;
            direction = Direction.North;
        }
        
       public void next_Rover(int X, int Y, Direction direction)
        {
            switch (direction)
            {
                case Direction.North:
                    if (X - 1 >= 0)
                    {
                        next_x = X - 1;
                        next_y = Y;
                    }

                    else Console.WriteLine("The rover can't move to this direction");
                    break;
                case Direction.East:
                    if (Y + 1 <= 14)
                    {
                        next_y = Y + 1;
                        next_x = X;
                    }
                    else Console.WriteLine("The rover can't move to this direction");
                    break;
                case Direction.South:
                    if (X + 1 <= 14)
                    {
                        next_x = X + 1;
                        next_y = Y;
                    }
                    else Console.WriteLine("The rover can't move to this direction");
                    break;
                case Direction.West:
                    if (Y - 1 >= 0)
                    {
                        next_y = Y - 1;
                        next_x = X;
                    }
                    else Console.WriteLine("The rover can't move to this direction");
                    break;
                default: throw new ArgumentOutOfRangeException();
            }
        }

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


