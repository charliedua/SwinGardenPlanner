using Planner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwinGardenPlanner
{
    public class Program
    {
        public static void PrintGrid(Cell[][] grid)
        {
            const float WIDTH = 3.0f;
            int NoOfDashes = (int)((WIDTH + 1) * grid.Length + 1);
            Console.WriteLine(new string('-', NoOfDashes));

            for (int i = 0; i < grid.Length; i++)
            {
                Console.Write("|");
                Console.Write(new string(' ', (int)WIDTH));
            }
            Console.WriteLine("|");
            for (int i = 0; i < grid.Length; i++)
            {
                Console.Write(new string('-', NoOfDashes));

                Console.WriteLine();
                foreach (Cell cell in grid[i])
                {
                    Console.Write("|");
                    Console.Write(new string(' ', (int)(WIDTH / 2 - 0.5)));
                    if (!cell.HasObject)
                        Console.Write(" ");
                    else
                        Console.Write("X");
                    Console.Write(new string(' ', (int)(WIDTH / 2 - 0.5)));
                }
                Console.WriteLine("|");
            }
            Console.WriteLine(new string('-', NoOfDashes));

            Console.WriteLine();
        }

        private static void Main(string[] args)
        {
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
            PrintGrid(cells);
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