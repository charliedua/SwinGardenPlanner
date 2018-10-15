using Microsoft.VisualStudio.TestTools.UnitTesting;
using Planner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Tests
{
    [TestClass()]
    public class GardenTests
    {
        private readonly Garden garden = new Garden();
        private const int WIDTH = 10;
        private const int HEIGHT = 10;

        public GardenTests()
        {
        }

        [TestMethod()]
        public void GardenWidthInputTest()
        {
            garden.Width = WIDTH;
            Assert.AreEqual(garden.Width, WIDTH);
        }

        [TestMethod()]
        public void GardenHeightInputTest()
        {
            garden.Height = HEIGHT;
            Assert.AreEqual(garden.Height, HEIGHT);
        }
    }
}