using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Commands
{
    public class SetBudgetCommand : Command
    {
        public SetBudgetCommand()
        {
        }

        public override List<string> Identifiers { get => new List<string> { "set-budget", "change-budget", "edit-budget" }; }

        public override string Execute(PlannerController Controller, string[] CommandText)
        {
            if (CommandText.Length != 2)
            {
                return "Unknown Input";
            }
            if (Identifiers.Contains(CommandText[0].ToLower()))
            {
                if (decimal.TryParse(CommandText[1], out decimal budget))
                {
                    if(budget >= 0)
                    {
                        Controller.CurrentUser.Budget = budget;
                        return $"Budget updated: {budget}";
                    }
                    else
                    {
                        return "Budget Can't Be Negative";
                    }
                }
                else
                {
                    return "Wrong syntax for budget";
                }
            }
            else
            {
                return "Wrong syntax for budget";
            }
        }
    }
}