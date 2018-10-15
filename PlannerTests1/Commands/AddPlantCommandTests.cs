using Microsoft.VisualStudio.TestTools.UnitTesting;
using Planner.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Commands.Tests
{
    [TestClass()]
    public class AddPlantCommandTests
    {
        private Command command = new AddPlantCommand();
        private PlannerController controller = new PlannerController();

        public AddPlantCommandTests()
        {
            controller.Garden = new Garden(5);
            controller.Plants = new List<Plant>
            {
                new Plant() { ID = 0, Name = "Mango", PlantDesc = "Grows in Summers", MaxTemperature = 50f, MinTemperature = 0f, Price = 12, WaterFrequency = 12 },
                new Plant() { ID = 1, Name = "Bananna", PlantDesc = "Grows all time", MaxTemperature = 50f, MinTemperature = 0f, Price = 15, WaterFrequency = 0 },
                new Plant() { ID = 2, Name = "MoneyPlant", PlantDesc = "Grows all time", MaxTemperature = 50f, MinTemperature = 0f, Price = 500, WaterFrequency = 10 },
                new Plant() { ID = 3, Name = "grass", PlantDesc = "Grows all time", MaxTemperature = 50f, MinTemperature = 0f, Price = 2, WaterFrequency = 1 }
            };
        }

        [TestMethod()]
        public void AddPlantInvalid()
        {
            string expected = "Wrong Syntax.";
            string actual = command.Execute(controller, new string[] { "add-plant", "3", "4", "p" });
            Assert.AreEqual(expected, actual);
            actual = command.Execute(controller, new string[] { "add-plant", "3", "p", "p" });
            Assert.AreEqual(expected, actual);
            actual = command.Execute(controller, new string[] { "add-plant", "p", "p", "p" });
            Assert.AreEqual(expected, actual);
            actual = command.Execute(controller, new string[] { "add-plasd", "p", "p", "p" });
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddPlantValid()
        {
            string actual = command.Execute(controller, new string[] { "add-plant", "3", "0", "1" });
            string expected = "Plant Created. Name: " + controller.Plants[3].Name;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddPlantOutsideGarden()
        {
            string actual = command.Execute(controller, new string[] { "add-plant", "3", "70", "19" });
            string expected = "Plant cant be planted outside the garden";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddPlantWithoutGarden()
        {
            controller.Garden = null;
            string actual = command.Execute(controller, new string[] { "add-plant", "3", "0", "1" });
            string expected = "You don't have a garden yet";
            Assert.AreEqual(expected, actual);
        }
    }
}