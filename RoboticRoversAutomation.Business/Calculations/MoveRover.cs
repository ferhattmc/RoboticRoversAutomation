using RoboticRoversAutomation.Domain.Constants;
using RoboticRoversAutomation.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoboticRoversAutomation.Business.Services
{
    public class MoveRover : IMoveRover
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Directions Direction { get; set; }

        private void TurnLeft()
        {
            switch (this.Direction)
            {
                case Directions.N:
                    this.Direction = Directions.W;
                    break;
                case Directions.E:
                    this.Direction = Directions.N;
                    break;
                case Directions.S:
                    this.Direction = Directions.E;
                    break;
                case Directions.W:
                    this.Direction = Directions.S;
                    break;
                default:
                    break;
            }
        }

        private void TurnRight()
        {
            switch (this.Direction)
            {
                case Directions.N:
                    this.Direction = Directions.E;
                    break;
                case Directions.S:
                    this.Direction = Directions.W;
                    break;
                case Directions.E:
                    this.Direction = Directions.S;
                    break;
                case Directions.W:
                    this.Direction = Directions.N;
                    break;
                default:
                    break;
            }
        }

        private void GoStraightAhead()
        {
            switch (this.Direction)
            {
                case Directions.N:
                    this.Y += 1;
                    break;
                case Directions.S:
                    this.Y -= 1;
                    break;
                case Directions.E:
                    this.X += 1;
                    break;
                case Directions.W:
                    this.X -= 1;
                    break;
                default:
                    break;
            }
        }
        public void StartMoving(List<int> maxPoints, string moves)
        {
            foreach (var move in moves)
            {
                switch (move)
                {
                    case 'M':
                        this.GoStraightAhead();
                        break;
                    case 'L':
                        this.TurnLeft();
                        break;
                    case 'R':
                        this.TurnRight();
                        break;
                    default:
                        Console.WriteLine($"Invalid Character {move}");
                        break;
                }
            }
            Console.WriteLine($"{this.X} {this.Y} {this.Direction}");
        }

    }
}
