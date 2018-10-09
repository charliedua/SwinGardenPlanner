using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Commands
{
    internal class AddPlantCommand : Command
    {
        public AddPlantCommand()
        {
        }

        public override string[] Identifiers { get; set; }

        public override string Execute(string CommandText)
        {
            throw new NotImplementedException();
        }
    }
}