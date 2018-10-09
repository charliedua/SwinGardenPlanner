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
            int[][] grid = new int[5][];
            for (int i = 0; i < grid.Length; i++)
            {
                grid[i] = new int[5];
            }
            string spaces = "   ";
            for (int i = 0; i < grid.Length; i++)
            {
                Console.Write("|");
                for (int j = 0; j < grid[j].Length; j++)
                {
                    Console.Write(spaces);
                }
                Console.WriteLine("|");
            }
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