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
        private float _maxTemperature;
        private float _minTemperature;

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

        public float MaxTemperature { get => _maxTemperature; set => _maxTemperature = value; }
        public float MinTemperature { get => _minTemperature; set => _minTemperature = value; }
        public string PlantDesc { get => _plantDesc; set => _plantDesc = value; }
        public string PlantFamily { get => _plantFamily; set => _plantFamily = value; }
        public int Price { get => _price; set => _price = value; }
        public int WaterFrequency { get => _waterFrequency; set => _waterFrequency = value; }
    }
}