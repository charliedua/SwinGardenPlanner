using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planner;
using Planner.Commands;

namespace Planner.Tests
{
    [TestClass()]
    public class AddGardenCommandTests
    {
        private Command command = new AddGardenCommand();
        private PlannerController Controller = new PlannerController();

        public AddGardenCommandTests()
        {
        }

        [TestMethod()]
        public void AddGardenWithValidText()
        {
            string text = command.Execute(Controller, new string[] { "add-garden", "10" });

            Assert.AreEqual(10, Controller.Garden.Height);
            Assert.AreEqual(10, Controller.Garden.Width);

            Assert.AreEqual(text, "New Garden Created. Size: 10");
            Controller = new PlannerController();
        }

        [TestMethod()]
        public void AddGardenWhenAlreadyExists()
        {
            Controller = new PlannerController();
            Controller.Garden = new Garden();
            string actual = command.Execute(Controller, new string[] { "add-garden", "10" });
            string expected = "Garden Already Exits";
            Assert.AreEqual(expected, actual);
            Controller = null;
        }

        [TestMethod]
        public void AddGardenWithWrongText()
        {
            Controller = new PlannerController();
            string actual = command.Execute(Controller, new string[] { "add-garden", "po" });
            string expected = "Wrong Syntax.";
            Assert.AreEqual(expected, actual);
            actual = command.Execute(Controller, new string[] { "add-", "po" });
            Assert.AreEqual(expected, actual);
            Controller = null;
        }
    }
}