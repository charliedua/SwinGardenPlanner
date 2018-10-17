using Microsoft.VisualStudio.TestTools.UnitTesting;
using Planner.Commands;

namespace Planner.Commands.Tests
{
    [TestClass()]
    public class SetBudgetCommandTests
    {
        private Command budgetCommand = new SetBudgetCommand();
        private PlannerController controller = new PlannerController("");

        [TestMethod()]// Checks if the budget command properly changes the budget of the user.
        public void TestBudgetChanges()
        {
            string actual = budgetCommand.Execute(controller, new string[] { "set-budget", "500" });
            string expected = "Budget updated: 500";
            Assert.AreEqual(expected, actual);

            actual = budgetCommand.Execute(controller, new string[] { "set-budget", "9600" });
            expected = "Budget updated: 9600";
            Assert.AreEqual(expected, actual);

            actual = budgetCommand.Execute(controller, new string[] { "set-budget", "0" });
            expected = "Budget updated: 0";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]// Tests if the user is allowed to enter a negative budget (they shouldn't be!)
        public void TestNegativeBudget()
        {
            string actual = budgetCommand.Execute(controller, new string[] { "set-budget", "-50" });
            string expected = "Negative budget";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]// Tests for bad syntax
        public void TestBadSyntax()
        {
            string actual = budgetCommand.Execute(controller, new string[] { "set-budget", "hello" });
            string expected = "Wrong syntax for budget";
            Assert.AreEqual(expected, actual);

            actual = budgetCommand.Execute(controller, new string[] { "set-potato", "500" });
            expected = "Wrong syntax for budget";
            Assert.AreEqual(expected, actual);

            actual = budgetCommand.Execute(controller, new string[] { "500", "set-budget" });
            expected = "Wrong syntax for budget";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]// Tests for other acceptable command syntaxes.
        public void TestOtherSyntax()
        {
            string actual = budgetCommand.Execute(controller, new string[] { "change-budget", "500" });
            string expected = "Budget updated: 500";
            Assert.AreEqual(expected, actual);

            actual = budgetCommand.Execute(controller, new string[] { "edit-budget", "9600" });
            expected = "Budget updated: 9600";
            Assert.AreEqual(expected, actual);
        }
    }
}

