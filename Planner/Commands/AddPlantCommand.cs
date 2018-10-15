﻿using System;
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
            Plant plant = controller.Plants.Find(x => x.ID == ID);
            if (plant == null)
            {
                return "Can't find the plant.";
            }
            if (X > controller.Garden.Width || Y > controller.Garden.Width)
            {
                return "Plant cant be planted outside the garden";
            }
            controller.Garden.Cells[X][Y].Object = plant;
            return "Plant Created. Name: " + plant.Name;
        }
    }
}