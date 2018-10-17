using Microsoft.VisualStudio.TestTools.UnitTesting;
using Planner.Commands;
using System.Collections.Generic;

namespace Planner.Commands.Tests
{
    [TestClass()]
    public class AddToolCommandTests
    {
        private Command toolCommand = new AddToolCommand();
        private PlannerController controller = new PlannerController("");

        public AddToolCommandTests()
        {
            controller.Garden = new Garden(5);
            controller.Tools = new List<Tool>
            {
                new Tool(0, "Shovel") { ToolDesc = "A shovel", Price = 35},
                new Tool(1, "Pitchfork") { ToolDesc = "A pitchfork", Price = 30},
                new Tool(2, "Hedge Clippers") { ToolDesc = "Some hedge clippers", Price = 40},
                new Tool(3, "Watering Can") { ToolDesc = "A watering can", Price = 25}
            };
        }

        [TestMethod]// Checks that adding a tool works.
        public void TestAddToolWorks()
        {
            string actual = toolCommand.Execute(controller, new string[] { "add-tool", "0", "1", "1" });
            string expected = "Tool added. Name: " + controller.Tools[0].Name;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]// Tests for bad syntax
        public void TestBadSyntax()
        {
            string actual = toolCommand.Execute(controller, new string[] { "add-tool", "l", "o", "l" });
            string expected = "Wrong syntax.";
            Assert.AreEqual(expected, actual);
            actual = toolCommand.Execute(controller, new string[] { "add-tool", "0", "p", "1" });
            Assert.AreEqual(expected, actual);
            actual = toolCommand.Execute(controller, new string[] { "add-plant", "0", "0", "0" });
            Assert.AreEqual(expected, actual);
            actual = toolCommand.Execute(controller, new string[] { "remove-garden", "225", "2522", "2522" });
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]// Checks that tools can't be added outside of the garden
        public void TestToolOutsideGarden()
        {
            string actual = toolCommand.Execute(controller, new string[] { "add-tool", "1", "500", "2500" });
            string expected = "Tool can't be placed outside the garden";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestToolWithoutGarden()
        {
            controller.Garden = null;
            string actual = toolCommand.Execute(controller, new string[] { "add-tool", "1", "0", "1" });
            string expected = "You don't have a garden yet";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestToolConflictingPositionTest()
        {
            controller.Garden.Cells[0][0].Object = controller.Plants[0];
            string actual = command.Execute(controller, new string[] { "add-plant", "1", "0", "0" });
            string expected = "The cell already has: " + controller.Plants[0].Name;
        }

        [TestMethod]
        public void CornorCaseEndOfArrayAdditionTest()
        {
            string actual = command.Execute(controller, new string[] { "add-plant", "3", "4", "4" });
            string expected = "Plant Created. Name: " + controller.Plants[3].Name;
            Assert.AreEqual(expected, actual);
        }
    }
}