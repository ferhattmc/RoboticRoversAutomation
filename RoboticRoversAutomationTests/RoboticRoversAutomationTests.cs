using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoboticRoversAutomation.Business.Services;
using RoboticRoversAutomation.Domain.Constants;
using System.Collections.Generic;

namespace RoboticRoversAutomationTests
{
    [TestClass]
    public class RoboticRoversAutomationTests
    {
        [TestMethod]
        public void Senario_55_12N_LMLMLMLMM()
        {
            MoveRover moveRover = new MoveRover()
            {
                X = 1,
                Y = 2,
                Direction = Directions.N
            };

            var maxPoints = new List<int>() { 5, 5 };
            var moves = "LMLMLMLMM";

            moveRover.StartMoving(maxPoints, moves);

            var actualOutput = $"{moveRover.X} {moveRover.Y} {moveRover.Direction}";
            var expectedOutput = "1 3 N";

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Senario55_33E_MRRMMRMRRM()
        {
            MoveRover moveRover = new MoveRover()
            {
                X = 3,
                Y = 3,
                Direction = Directions.E
            };

            var maxPoints = new List<int>() { 5, 5 };
            var moves = "MRRMMRMRRM";

            moveRover.StartMoving(maxPoints, moves);

            var actualOutput = $"{moveRover.X} {moveRover.Y} {moveRover.Direction}";
            var expectedOutput = "2 3 S";

            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
