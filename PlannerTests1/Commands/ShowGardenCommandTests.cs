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
    public class ShowGardenCommandTests
    {
        private Command command = new ShowGardenCommand();
        private PlannerController controller = new PlannerController();

        [TestMethod()]
        public void GetHumanReadableGridTest()
        {
            controller.Garden = new Garden(5);
            string actual = command.Execute(controller, new string[] { "show-garden" });
            string expected = "---------------------\r\n|   |   |   |   |   |\r\n---------------------\r\n|   |   |   |   |   |\r\n---------------------\r\n|   |   |   |   |   |\r\n---------------------\r\n|   |   |   |   |   |\r\n---------------------\r\n|   |   |   |   |   |\r\n---------------------\r\n\r\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShowGardenWhenNoGarden()
        {
            controller.Garden = null;
            string actual = command.Execute(controller, new string[] { "show-garden" });
            string expected = "Please Create a Garden First.";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShowGardenWrongFormat()
        {
            string actual = command.Execute(controller, new string[] { "show-gdernn" });
            string expected = "Wrong Syntax.";
            Assert.AreEqual(expected, actual);
        }
    }
}