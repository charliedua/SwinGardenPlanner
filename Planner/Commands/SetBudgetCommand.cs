using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Commands
{
    internal class SetBudgetCommand : Command
    {
        public SetBudgetCommand()
        {
        }

        public override List<string> Identifiers { get => new List<string> { "set-budget", "change-budget", "edit-budget" }; }

        public override string Execute(PlannerController Controller, string[] CommandText)
        {
            if (CommandText.Length <= 0)
            {
                return "Unknown Input";
            }

            if (Identifiers.Contains(CommandText[0].ToLower()))
            {
                if (decimal.TryParse(CommandText[1], out decimal budget))
                {
                    Controller.CurrentUser.Budget = budget;
                    return $"budget Updated: {budget}";
                }
                else
                {
                    return "Wrong Syntax for budget";
                }
            }
            else
            {
                return "Wrong Syntax for budget";
            }
        }
    }
}