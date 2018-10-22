using Microsoft.VisualStudio.TestTools.UnitTesting;
using Planner.Commands;
using System.Collections.Generic;

namespace Planner.Commands.Tests
{
    [TestClass()]
    public class RemovePlantCommandTests
    {
        private Command removeCommand = new RemovePlantCommand();

        private PlannerController controller = new PlannerController("TestUser")
        {
            Plants = new List<Plant>
            {
                new Plant(0, "Mango") { PlantDesc = "Grows in Summer", MaxTemperature = 50f, MinTemperature = 0f, Price = 12, WaterFrequency = 12 },
                new Plant(1, "Banana") { PlantDesc = "Grows any time", MaxTemperature = 50f, MinTemperature = 0f, Price = 15, WaterFrequency = 0 },
                new Plant(2,"Money Plant") { PlantDesc = "Grows any time", MaxTemperature = 50f, MinTemperature = 0f, Price = 500, WaterFrequency = 10 },
                new Plant(3, "Grass") { PlantDesc = "Grows any time", MaxTemperature = 50f, MinTemperature = 0f, Price = 2, WaterFrequency = 1 }
            }
        };

        private Command addCommand = new AddPlantCommand();

        [TestInitialize]
        public void RemovePlantCommandTestsInit()
        {
            controller.Garden = new Garden(5);
        }

        [TestMethod()]// Trying to remove a plant that is yet to be added.
        public void TestPlantNotFound()
        {
            string actual = removeCommand.Execute(controller, new string[] { "remove-plant", "0", "0" });
            string expected = "The Cell Is Already Empty";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]// Successfully removing a plant that has been added.
        public void TestPlantRemoved()
        {
            addCommand.Execute(controller, new string[] { "add-plant", "0", "0", "0" });
            string actual = removeCommand.Execute(controller, new string[] { "remove-plant", "0", "0" });
            string expected = controller.Garden.Cells[0][0].Object.Name + " removed from garden.";
            Assert.AreEqual(expected, actual);

            actual = removeCommand.Execute(controller, new string[] { "remove-plant", "0", "0" });
            expected = "Plant could not be found.";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()] // Using the wrong command syntax, or spelling it wrong.
        public void TestWrongSyntax()
        {
            string expected = "Wrong Syntax.";
            string actual = removeCommand.Execute(controller, new string[] { "remove-plant", "s", "b" });
            Assert.AreEqual(expected, actual);
            actual = removeCommand.Execute(controller, new string[] { "remove-palnt", "0", "2" });
            Assert.AreEqual(expected, actual);
            actual = removeCommand.Execute(controller, new string[] { "remove plant", "5", "2" });
            Assert.AreEqual(expected, actual);
        }

        // Integration Test
        [TestMethod]
        public void TestPlantRemovedChangedBudget()
        {
            decimal oldBudget = controller.CurrentUser.Budget;
            addCommand.Execute(controller, new string[] { "add-plant", "0", "0", "0" });
            removeCommand.Execute(controller, new string[] { "remove-plant", "0", "0" });
            decimal actual = controller.CurrentUser.Budget;
            decimal expected = oldBudget;
            Assert.AreEqual(expected, actual);
        }
    }
}