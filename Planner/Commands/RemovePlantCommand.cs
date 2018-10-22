using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Commands
{
    public class RemovePlantCommand : Command
    {
        public RemovePlantCommand()
        {
        }

           /*
            * remove-plant [INT] [INT]
            * remove-plant [ X ] [ Y ]
            */

        public override List<string> Identifiers => new List<string>() { "remove-plant" };
        public override string Execute(PlannerController controller, string[] CommandText)
        {
            if (!AreYou(CommandText[0]) || CommandText.Length != 3 || !int.TryParse(CommandText[1], out int X) || !int.TryParse(CommandText[2], out int Y))
            {
                return "Wrong Syntax.";
            }
            if (X + 1 > controller.Garden.Width || Y + 1 > controller.Garden.Width || X < 0 || Y < 0)
            {
                return "You Can Only Remove From Within Your Garden";
            }
            if (!controller.Garden.Cells[X][Y].HasObject)
            {
                return "The Cell Is Already Empty";
            }
            else
            {
                string removed = controller.Garden.Cells[X][Y].Object.Name + " removed from garden";
                int ID = controller.Garden.Cells[X][Y].Object.ID;
                Plant plant = controller.Plants.Find(x => x.ID == ID);
                controller.Garden.Cells[X][Y].Object = plant;
                controller.CurrentUser.Budget += plant.Price;
                controller.Garden.Cells[X][Y].Object = null;
                return removed;
            }
        }
    }
}