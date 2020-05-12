using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public class Rover
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Direction Direction { get; set; }
        
        public Rover(int x, int y, Direction direction)
        {
            X = x;
            Y = y;
            Direction = direction;
        }

        public void Move()
        {
            switch (Direction)
            {
                case Direction.N:
                    if (Y + 1 <= 15)
                        Y += 1;
                    break;
                case Direction.E:
                    if (X + 1 <= 15)
                        X += 1;
                    break;
                case Direction.S:
                    if (Y - 1 >= 0)
                        Y -= 1;
                    break;
                case Direction.W:
                    if (X - 1 >= 0)
                        X -= 1;
                    break;
                default: throw new ArgumentOutOfRangeException();
            }
        }

        
    }
}
