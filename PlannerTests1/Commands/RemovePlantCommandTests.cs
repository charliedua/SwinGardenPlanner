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
        private Command command = new AddPlantCommand();
        private PlannerController controller = new PlannerController();

        public RemovePlantCommandTests()
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

        [TestInitialize]
        public void Init()
        {
            command = new AddPlantCommand();
            controller = new PlannerController
            {
                Garden = new Garden(5),
                Plants = new List<Plant>
            {
                new Plant(0, "Mango") { PlantDesc = "Grows in Summers", MaxTemperature = 50f, MinTemperature = 0f, Price = 12, WaterFrequency = 12 },
                new Plant(1, "Bananna") { PlantDesc = "Grows all time", MaxTemperature = 50f, MinTemperature = 0f, Price = 15, WaterFrequency = 0 },
                new Plant(2,"MoneyPlant") { PlantDesc = "Grows all time", MaxTemperature = 50f, MinTemperature = 0f, Price = 500, WaterFrequency = 10 },
                new Plant(3, "grass") { PlantDesc = "Grows all time", MaxTemperature = 50f, MinTemperature = 0f, Price = 2, WaterFrequency = 1 }
            }
            };
        }

        [TestMethod()]
        public void ExecuteTest()
        {
        }

        [TestCleanup()]
        public void Thing()
        {
        }
    }
}