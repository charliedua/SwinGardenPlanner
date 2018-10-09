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

        public override string[] Identifiers { get; set; }

        public override string Execute(string CommandText)
        {
            throw new NotImplementedException();
        }
    }
}