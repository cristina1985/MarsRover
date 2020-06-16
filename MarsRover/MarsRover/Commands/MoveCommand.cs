using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MarsRover.Commands
{
    public class MoveCommand : ICommand
    {
        public MoveCommand(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }
    }
}
