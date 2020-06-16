using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Commands
{
    public class ChangeOrientationCommand : ICommand
    {
        public ChangeOrientationCommand(Direction direction)
        {
            Direction = direction;
        }
        public Direction Direction { get; set; }
    }
}
