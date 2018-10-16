﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Planner.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Commands.Tests
{
    [TestClass()]
    public class RemovePlantCommandTests
    {
        private Command removeCommand = new RemovePlantCommand();
        private PlannerController controller = new PlannerController("");
        private Command addCommand = new AddPlantCommand();

        [TestInitialize]
        public void RemovePlantCommandTestsInit()
        {

            controller.Garden = new Garden(5);
            controller.Plants = new List<Plant>
            {
                new Plant(0, "Mango") { PlantDesc = "Grows in Summers", MaxTemperature = 50f, MinTemperature = 0f, Price = 12, WaterFrequency = 12 },
                new Plant(1, "Bananna") { PlantDesc = "Grows all time", MaxTemperature = 50f, MinTemperature = 0f, Price = 15, WaterFrequency = 0 },
                new Plant(2,"MoneyPlant") { PlantDesc = "Grows all time", MaxTemperature = 50f, MinTemperature = 0f, Price = 500, WaterFrequency = 10 },
                new Plant(3, "grass") { PlantDesc = "Grows all time", MaxTemperature = 50f, MinTemperature = 0f, Price = 2, WaterFrequency = 1 }
            };
        }

        [TestMethod()]// Trying to remove a plant that is yet to be added.
        public void TestPlantNotFound()
        {
            string actual = removeCommand.Execute(controller, new string[] { "remove-plant", "0", "0" });
            string expected = "Plant could not be found.";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]// Successfully removing a plant that has been added.
        public void TestPlantRemoved()
        {
            addCommand.Execute(controller, new string[] { "add-plant", "0", "0", "0" });
            string actual = removeCommand.Execute(controller, new string[] { "remove-plant", "0", "0" });
            string expected = "Plant removed from garden.";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()] // Using the wrong command syntax!
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
    }
}