using MarsRover.Commands;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MarsRover
{
    public class Orchastrator
    {
        private int _runs = 0;
        private int _x = 0;
        private int _y = 0;
        private int move_x = 0;
        private int move_y = 0;

        private Direction _direction = Direction.North;
        private Map _map = new Map();
        private Rover _rover;
        public string[,] index = new string[15, 15];
        

        public Orchastrator()
        {
            _rover = new Rover(_x, _y, _direction);
        }

        public ContinuationType Run()
        {
            if (_runs == 0)
            {
                GetInitialInfo();
                _map.PrintMap(_x, _y, _direction);
            }
                
            var abstractCommand = GetCommand();
          
            if (abstractCommand is MoveCommand)
            {
                var command = abstractCommand as MoveCommand;
                /* _x = command.X;
                 _y = command.Y;
                 if (_rover.Move(_x,_y) == true)
                 {
                     Console.Clear();
                     _map.PrintMap(_x,_y, _direction);
                 } */

                move_x = command.X;
                move_y = command.Y;
                switch (_direction)
                {
                    case Direction.North:
                        if ((move_x >= 0) && (move_x == _x - 1))
                        {
                            Console.Clear();
                            _map.PrintMap(move_x, move_y, _direction);
                        }
                        else Console.WriteLine("The rover can't move to this direction");
                        break;

                    case Direction.East:
                        if ((move_y <= 14) && (move_y == _y + 1))
                        {
                            Console.Clear();
                            _map.PrintMap(move_x, move_y, _direction);
                        }
                        else Console.WriteLine("The rover can't move to this direction");
                        break;

                    case Direction.West:
                        if ((move_y >= 0) && (move_y == _y - 1))
                        {
                            Console.Clear();
                            _map.PrintMap(move_x, move_y, _direction);
                        }
                        else Console.WriteLine("The rover can't move to this direction");
                        break;

                    case Direction.South:
                        if ((move_x <=14 ) && (move_x == _x + 1))
                        {
                            Console.Clear();
                            _map.PrintMap(move_x, move_y, _direction);
                        }
                        else Console.WriteLine("The rover can't move to this direction");
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
                _runs += 1;
                
            }
            else 
            if (abstractCommand is ChangeOrientationCommand)
                {
                    var command = abstractCommand as ChangeOrientationCommand;
                    _direction = command.Direction;                  
                    Console.Clear();
                    _map.PrintMap(_x, _y, _direction);
                    _runs += 1;
                }


                // _runs += 1;
                return ContinuationType.Continue;
            }
        private void GetInitialInfo()
        {
            Console.WriteLine("Please provide the rover coordinates separated by space \n [ the values shoud be between 0 and 14 ] :");
            string[] values = Console.ReadLine().Split(' ');
            _x = int.Parse(values[0]);
            _y = int.Parse(values[1]);
            _direction = Direction.North;
            Console.WriteLine();

        }

        private ICommand GetCommand()
        {
            
            string[] command = Console.ReadLine().Split(' ');

            int size = command.Length;
            string nextArg = "";

            for (var counter = 0; counter < size; counter++)
            {
                if (counter + 1 < size)
                    nextArg = command[counter + 1];
                switch (command[counter])
                {
                    case "-m":
                    case "--move":
                        string[] coords = nextArg.Split(',');
                        return new MoveCommand(int.Parse(coords[0]), int.Parse(coords[1]));
                        
               
                
                    case "-co":
                    case "--changeOrientation":
                        switch (nextArg)
                        {
                            case "N":
                                return new ChangeOrientationCommand(Direction.North);
                            case "S":
                                return new ChangeOrientationCommand(Direction.South);
                            case "E":
                                return new ChangeOrientationCommand(Direction.East);
                            case "W":
                                return new ChangeOrientationCommand(Direction.West);
                            default:
                                return null;
                        }
                }
            }
            return null;
        }

    }
}
