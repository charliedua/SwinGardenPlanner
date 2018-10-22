using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Commands
{
    public class AddPlantCommand : Command
    {
        public AddPlantCommand()
        {
        }

        /*
         * add-plant [INT ] [INT] [INT]
         * add-plant [ ID ] [ X ] [ Y ]
         */

        public override List<string> Identifiers => new List<string>() { "add-plant" };

        public override string Execute(PlannerController controller, string[] CommandText)
        {
            if (!AreYou(CommandText[0]) || CommandText.Length != 4 || !int.TryParse(CommandText[1], out int ID) || !int.TryParse(CommandText[2], out int X) || !int.TryParse(CommandText[3], out int Y))
            {
                return "Wrong Syntax.";
            }
            if (controller.Garden == null)
            {
                return "You don't have a garden yet";
            }
            Plant plant = controller.Plants.Find(x => x.ID == ID);
            if (plant == null)
            {
                return "Can't find the plant.";
            }
            if (X + 1 > controller.Garden.Width || Y + 1 > controller.Garden.Width || X < 0 || Y < 0)
            {
                return "Plant cant be planted outside the garden";
            }
            if (controller.Garden.Cells[X][Y].HasObject)
            {
                return "The cell already has: " + controller.Garden.Cells[X][Y].Object.Name;
            }
            controller.Garden.Cells[X][Y].Object = plant;
            controller.CurrentUser.Budget -= plant.Price;
            return "Plant Created. Name: " + plant.Name;
        }
    }
}