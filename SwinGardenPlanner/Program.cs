using Planner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwinGardenPlanner
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // (3+1)*3 + 1 = 13

            Cell[][] cells = new Cell[15][];
            for (int i = 0; i < cells.Length; i++)
            {
                cells[i] = new Cell[15];
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

        public static void PrintGrid(Cell[][] grid)
        {
            const int WIDTH = 3;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < ((WIDTH + 1) * grid.Length + 1); j++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();
                foreach (Cell cell in grid[i])
                {
                    Console.Write("|");
                    for (int k = 0; k < (int)(WIDTH / 2 - 0.5); k++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(" ");
                    if (!cell.HasObject)
                        Console.Write(" ");
                    else
                        Console.Write("X");
                    for (int k = 0; k < (int)(WIDTH / 2 - 0.5); k++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(" ");
                }
                Console.WriteLine("|");
            }
            for (int j = 0; j < ((WIDTH + 1) * grid.Length + 1); j++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
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