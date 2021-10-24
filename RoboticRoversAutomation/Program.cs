using RoboticRoversAutomation.Business.Services;
using RoboticRoversAutomation.Business.Utilities;
using RoboticRoversAutomation.Domain.Constants;
using RoboticRoversAutomation.Domain.Structs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RoboticRoversAutomation
{
    class Program
    {
        static void Main(string[] args)
        {

            var maxCoordinates = new List<int>();
            do
            {
                Console.WriteLine("Enter upper-right coordinates of the plateau (Format Should Be 'X Y') :");
                maxCoordinates = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            } while (maxCoordinates.Count != 2);

            var startingCoordinates = new List<string>();
            do
            {
                Console.WriteLine($"Enter rover's coordinates of the starting and should between ({maxCoordinates[0]} , {maxCoordinates[1]}) (Format Should Be 'X Y D'):");
                startingCoordinates = Console.ReadLine().Trim().Split(' ').ToList();
            } while (startingCoordinates.Count != 3 || Guard.IsInsideBoundary(maxCoordinates, Convert.ToInt32(startingCoordinates[0]), Convert.ToInt32(startingCoordinates[1])));


            MoveRover moveRover = new MoveRover
            {
                X = Convert.ToInt32(startingCoordinates[0]),
                Y = Convert.ToInt32(startingCoordinates[1]),
                Direction = (Directions)Enum.Parse(typeof(Directions), startingCoordinates[2])
            };
                       
            
            Console.WriteLine("Enter rover's movement:");
            var moves = Console.ReadLine().ToUpper();

            try
            {
                moveRover.StartMoving(maxCoordinates, moves);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }

    }
}
