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
        private static void Main(string[] args)
        {
            PlannerController controller = new PlannerController();
            CommandProcessor processor = new CommandProcessor();
            controller.Plants = new List<Plant>
            {
                new Plant(0, "Mango") { PlantDesc = "Grows in Summers", MaxTemperature = 50f, MinTemperature = 0f, Price = 12, WaterFrequency = 12 },
                new Plant(1, "Bananna") { PlantDesc = "Grows all time", MaxTemperature = 50f, MinTemperature = 0f, Price = 15, WaterFrequency = 0 },
                new Plant(2,"MoneyPlant") { PlantDesc = "Grows all time", MaxTemperature = 50f, MinTemperature = 0f, Price = 500, WaterFrequency = 10 },
                new Plant(3, "grass") { PlantDesc = "Grows all time", MaxTemperature = 50f, MinTemperature = 0f, Price = 2, WaterFrequency = 1 }
            };
            string text;
            while (true)
            {
                Console.Write("Enter your command here $ ");
                text = Console.ReadLine();
                Console.WriteLine(processor.Execute(controller, text));
            }

            // (3+1)*3 + 1 = 13
            //const int GARDEN_LENGTH = 15;
            //Cell[][] cells = new Cell[GARDEN_LENGTH][];
            //for (int i = 0; i < cells.Length; i++)
            //{
            //    cells[i] = new Cell[GARDEN_LENGTH];
            //}
            //for (int i = 0; i < cells.Length; i++)
            //{
            //    for (int j = 0; j < cells[i].Length; j++)
            //    {
            //        cells[i][j] = new Cell(i + 1, j + 1);
            //    }
            //}
            //cells[9][4].Object = new GardenObject();
            //cells[4][4].Object = new GardenObject();
            //cells[4][8].Object = new GardenObject();
            //Console.Write(GetHumanReadableGrid(cells));
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