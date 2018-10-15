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

        public override List<string> Identifiers => new List<string>() { "add-garden" };

        public override string Execute(PlannerController controller, string[] CommandText)
        {
            if (!Identifiers.Contains(CommandText[0]) || !int.TryParse(CommandText[1], out int size))
            {
                return "Wrong Syntax.";
            }
            if (controller.Garden != null)
            {
                return "Garden Already Exits";
            }
            else
            {
                controller.Garden = new Garden
                {
                    Height = size,
                    Width = size
                };
                return "New Garden Created. Size: " + controller.Garden.Height;
            }
        }
    }
}