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

            if(CommandText[0].ToLower == Identifiers[0])
            {
                Controller.CurrentUser.Budget = CommandText[1];
            }

            Identifiers.Find(x => x == CommandText[0]);
            throw new NotImplementedException();
        }
    }
}