using Planner;
using Planner.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwinGardenPlanner
{
    public class Program
    {
        public static string GetHumanReadableGrid(Cell[][] grid)
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

        private static void Main(string[] args)
        {
            PlannerController controller = new PlannerController();
            //controller.CurrentUser = new User();
            Command command = new AddGardenCommand();
            string text;
            while (true)
            {
                Console.Write("Enter your command here $ ");
                text = Console.ReadLine();
                Console.WriteLine(command.Execute(controller, text.Split(' ')));
            }

            // (3+1)*3 + 1 = 13
            const int GARDEN_LENGTH = 15;
            Cell[][] cells = new Cell[GARDEN_LENGTH][];
            for (int i = 0; i < cells.Length; i++)
            {
                cells[i] = new Cell[GARDEN_LENGTH];
            }
            for (int i = 0; i < cells.Length; i++)
            {
                for (int j = 0; j < cells[i].Length; j++)
                {
                    cells[i][j] = new Cell(i + 1, j + 1);
                }
            }
            cells[9][4].Object = new GardenObject();
            cells[4][4].Object = new GardenObject();
            cells[4][8].Object = new GardenObject();
            Console.Write(GetHumanReadableGrid(cells));
        }
    }
}

/*
 * ---------
 * |   |   |
 * ---------
 *
 *
 *
 */