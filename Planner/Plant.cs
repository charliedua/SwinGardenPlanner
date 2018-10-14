using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner
{
    public class Plant : GardenObject
    {
        private string _plantDesc;
        private string _plantFamily;
        private int _price;
        private int _waterFrequency;
        private float MaxTemperature;
        private float MinTemperature;

        public Plant()
        {
        }

        private enum Season
        {
            Summer, Autumn, Winter, Spring
        }

        private enum SunTolerance
        {
            FullSun, PartShade, FullShade
        }

        public float MaxTemperature1 { get => MaxTemperature; set => MaxTemperature = value; }
        public float MinTemperature1 { get => MinTemperature; set => MinTemperature = value; }
        public string PlantDesc { get => _plantDesc; set => _plantDesc = value; }
        public string PlantFamily { get => _plantFamily; set => _plantFamily = value; }
        public int Price { get => _price; set => _price = value; }
        public int WaterFrequency { get => _waterFrequency; set => _waterFrequency = value; }
    }
}