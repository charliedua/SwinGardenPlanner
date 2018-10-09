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

        public override string Execute(string[] CommandText)
        {
            if (CommandText.Length <= 0)
            {
                return "Wrong Idea";
            }
            Identifiers.Find(x => x == CommandText[0]);
            throw new NotImplementedException();
        }
    }
}