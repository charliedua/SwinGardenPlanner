using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Commands
{
    public class ShowGardenCommand : Command
    {
        public ShowGardenCommand()
        {
        }

        public override List<string> Identifiers => new List<string>() { "show-garden", "display-garden" };

        public override string Execute(PlannerController controller, string[] CommandText)
        {
            return GetHumanReadableGrid(controller.Garden.Cells);
        }

        private static string GetHumanReadableGrid(Cell[][] grid)
        {
            const float WIDTH = 3.0f;
            int NoOfDashes = (int)((WIDTH + 1) * grid.Length + 1);
            StringBuilder builder = new StringBuilder();
            builder.AppendLine(new string('-', NoOfDashes));

            for (int i = 0; i < grid.Length; i++)
            {
                builder.Append("|");
                builder.Append(new string(' ', (int)WIDTH));
            }
            builder.AppendLine("|");
            for (int i = 0; i < grid.Length; i++)
            {
                builder.Append(new string('-', NoOfDashes));

                builder.AppendLine();
                foreach (Cell cell in grid[i])
                {
                    builder.Append("|");
                    builder.Append(new string(' ', (int)(WIDTH / 2 - 0.5)));
                    if (!cell.HasObject)
                        builder.Append(" ");
                    else
                        builder.Append("X");
                    builder.Append(new string(' ', (int)(WIDTH / 2 - 0.5)));
                }
                builder.AppendLine("|");
            }
            builder.AppendLine(new string('-', NoOfDashes));
            builder.AppendLine();
            return builder.ToString();
        }
    }
}