using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Commands
{
    public class AddGardenCommand : Command
    {
        public AddGardenCommand()
        {
        }

        /*
         * add-garden [INT]
         */

        public override List<string> Identifiers => throw new NotImplementedException();

        public override string Execute(PlannerController controller, string[] CommandText)
        {
            throw new NotImplementedException();
        }
    }
}